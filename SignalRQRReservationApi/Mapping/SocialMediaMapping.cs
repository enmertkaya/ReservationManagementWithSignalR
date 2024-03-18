using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.DtoLayer.SocialMediaDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        }
    }
}
