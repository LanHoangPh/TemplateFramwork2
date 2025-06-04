using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TemplateFramework.Application.Mapping;
using TemplateFramework.Application.Services.Implements;
using TemplateFramework.Application.Services.Interfaces;
using TemplateFramework.Application.Validations;
using TemplateFramework.Domain.Interfaces;


namespace TemplateFramework.Application.DependencyInjection
{
    public static class ServerContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<RegisterUserDtoValidate>();
            services.AddValidatorsFromAssemblyContaining<LoginUserDtoValidate>();

            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICallProcedureProduct, CallProcedureProduct>();
            return services;
        }
    }
}
