using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();

        }
    }
}
