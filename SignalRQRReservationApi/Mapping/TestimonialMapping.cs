using AutoMapper;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.DtoLayer.TestimonialDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
        }
    }
}
