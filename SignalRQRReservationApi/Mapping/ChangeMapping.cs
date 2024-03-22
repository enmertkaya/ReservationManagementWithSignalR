using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.DtoLayer.ChangeDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class ChangeMapping : Profile
    {
        public ChangeMapping()
        {
            CreateMap<Change, ResultChangeDto>().ReverseMap();
            CreateMap<Change, GetChangeDto>().ReverseMap();
            CreateMap<Change, UpdateChangeDto>().ReverseMap();
            CreateMap<Change, CreateChangeDto>().ReverseMap();
            CreateMap<Change, ResultChangeWithCategoryDto>().ReverseMap();

        }
    }
}
