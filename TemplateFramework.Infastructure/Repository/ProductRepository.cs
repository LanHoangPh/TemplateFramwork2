using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;
using TemplateFramework.Infastructure.Data;

namespace TemplateFramework.Infastructure.Repository
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(TemplateDbContext context) : base(context)
        {
        }
    }
}
