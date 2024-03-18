using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.DtoLayer.BookingDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
        }
    }
}
