using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemplateFramework.Application.Mapping
{
    public class MapperCustom
    {
        private static readonly ConcurrentDictionary<(Type Source, Type Destination), Delegate> _mappingCache = new();

        public TDestination Map<TSource, TDestination>(TSource source) where TDestination : new()
        {
            if (source == null) return default;

            // Lấy delegate mapping từ cache hoặc tạo mới
            var key = (typeof(TSource), typeof(TDestination));
            var mappingDelegate = (Func<TSource, TDestination>)_mappingCache.GetOrAdd(key, CreateMappingDelegate<TSource, TDestination>);

            return mappingDelegate(source);
        }

        private Delegate CreateMappingDelegate<TSource, TDestination>()
            where TDestination : new()
        {
            var sourceType = typeof(TSource);
            var destType = typeof(TDestination);

            // Parameter cho source object
            var sourceParameter = Expression.Parameter(sourceType, "source");

            // Tạo instance mới cho destination
            var destination = Expression.New(destType);

            // Danh sách các binding để gán giá trị cho properties
            var bindings = new List<MemberBinding>();

            // Lấy tất cả properties của destination
            var destProperties = destType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite);

            foreach (var destProp in destProperties)
            {
                // Tìm property tương ứng trong source
                var sourceProp = sourceType.GetProperty(destProp.Name, BindingFlags.Public | BindingFlags.Instance);
                if (sourceProp != null && sourceProp.PropertyType == destProp.PropertyType && sourceProp.CanRead)
                {
                    // Gán giá trị từ source sang destination
                    var sourceValue = Expression.Property(sourceParameter, sourceProp);
                    var binding = Expression.Bind(destProp, sourceValue);
                    bindings.Add(binding);
                }
            }

            // Tạo expression tree cho mapping
            var memberInit = Expression.MemberInit(destination, bindings);
            var lambda = Expression.Lambda<Func<TSource, TDestination>>(memberInit, sourceParameter);

            // Biên dịch lambda thành delegate
            return lambda.Compile();
        }

        // Hỗ trợ tùy chỉnh mapping thủ công
        public void ConfigureMapping<TSource, TDestination>(Func<TSource, TDestination> customMapping)
        {
            var key = (typeof(TSource), typeof(TDestination));
            _mappingCache[key] = customMapping;
        }
        public IEnumerable<TDestination> MapCollection<TSource, TDestination>(IEnumerable<TSource> sources) where TDestination : new()
        {
            if (sources == null) yield break;
            foreach (var source in sources)
            {
                yield return Map<TSource, TDestination>(source);
            }
        }

        public TDestination MapNested<TSource, TDestination>(TSource source)
            where TDestination : new()
        {
            var result = Map<TSource, TDestination>(source);

            // Xử lý nested objects
            var sourceProps = typeof(TSource).GetProperties();
            var destProps = typeof(TDestination).GetProperties();

            foreach (var destProp in destProps)
            {
                var sourceProp = sourceProps.FirstOrDefault(p => p.Name == destProp.Name);
                if (sourceProp != null && !sourceProp.PropertyType.IsPrimitive && sourceProp.PropertyType != typeof(string))
                {
                    var nestedSource = sourceProp.GetValue(source);
                    if (nestedSource != null)
                    {
                        var nestedDest = Activator.CreateInstance(destProp.PropertyType);
                        var mapMethod = GetType().GetMethod(nameof(Map)).MakeGenericMethod(sourceProp.PropertyType, destProp.PropertyType);
                        var nestedMapped = mapMethod.Invoke(this, new[] { nestedSource });
                        destProp.SetValue(result, nestedMapped);
                    }
                }
            }

            return result;
        }
    }
}
