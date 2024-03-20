using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRQRReservation.BusinessLayer.Abstract;
using SignalRQRReservation.DtoLayer.SocialMediaDto;
using SignalRQRReservation.DtoLayer.TestimonialDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial (CreateTestimonialDto createTestimonialDto) 
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment = createTestimonialDto.Comment,
                Description = createTestimonialDto.Description,
                ImageURL= createTestimonialDto.ImageURL,
                Name = createTestimonialDto.Name,
                Status = createTestimonialDto.Status  
            });
            return Ok("Yorum bilgisi eklendi");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialID=updateTestimonialDto.TestimonialID,
                Comment = updateTestimonialDto.Comment,
                Description = updateTestimonialDto.Description,
                ImageURL = updateTestimonialDto.ImageURL,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status
            });
            return Ok("Sosyal medya güncellendi");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial (int id)
        {
            var value=_testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Yorum bilgisi silindi");
        }

    }
}
