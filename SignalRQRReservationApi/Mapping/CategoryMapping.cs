using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.DtoLayer.CategoryDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
        }
    }
}
