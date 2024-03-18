using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.DtoLayer.HomePageDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class HomePageMapping : Profile
    {
        public HomePageMapping()
        {
            CreateMap<HomePage, ResultHomePageDto>().ReverseMap();
            CreateMap<HomePage, GetHomePageDto>().ReverseMap();
            CreateMap<HomePage, UpdateHomePageDto>().ReverseMap();
            CreateMap<HomePage, CreateHomePageDto>().ReverseMap();
        }
    }
}
