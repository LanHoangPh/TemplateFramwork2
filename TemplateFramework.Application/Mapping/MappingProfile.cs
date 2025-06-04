using AutoMapper;
using TemplateFramework.Application.DTOs.Auth;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Domain.Entities;

namespace TemplateFramework.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<RegisterUserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.RefreshTokens, opt => opt.Ignore());

            CreateMap<Products, ProductResponse>();
            CreateMap<CreateProductDto, Products>();
            CreateMap<UpdateProductDto, Products>();

        }
    }
}
