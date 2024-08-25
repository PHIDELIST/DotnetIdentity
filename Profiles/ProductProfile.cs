using AutoMapper;
using backend.Models.DbSet;
using backend.Models.Dtos;

namespace backend.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, GetProduct>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ImageAlt, opt => opt.MapFrom(src => src.ImageAlt))
                .ForMember(dest => dest.ImageSrc, opt => opt.MapFrom(src => src.ImageSrc))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price));

        }
    }
}
