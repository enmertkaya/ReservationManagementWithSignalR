using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRQRReservation.BusinessLayer.Abstract;
using SignalRQRReservation.DtoLayer.AboutDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList ()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout ( CreateAboutDto createAboutDto )
        {
            About about = new About()
            {
                Address = createAboutDto.Address,
                Age = createAboutDto.Age,
                Birthday = createAboutDto.Birthday,
                Description= createAboutDto.Description,
                Education= createAboutDto.Education,
                Experience= createAboutDto.Experience,
                ImageURL= createAboutDto.ImageURL,
                Mail= createAboutDto.Mail,
                Phone= createAboutDto.Phone,
                SocialMedia= createAboutDto.SocialMedia,
                Title1 = createAboutDto.Title1,
                Title1Description= createAboutDto.Title1Description,
                Title2 = createAboutDto.Title2,
                Title2Description= createAboutDto.Title2Description,
                Title2MiniDescription= createAboutDto.Title2MiniDescription
            };

            _aboutService.TAdd(about);
            return Ok("Hakkımda kısmı başarılı bir şekilde eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAbout (int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);
            return Ok("Hakkımda Alanı Silindi");
        }

        [HttpPut]
        public IActionResult UpdateAbout ( UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID= updateAboutDto.AboutID,
                Address = updateAboutDto.Address,
                Age = updateAboutDto.Age,
                Birthday = updateAboutDto.Birthday,
                Description = updateAboutDto.Description,
                Education = updateAboutDto.Education,
                Experience = updateAboutDto.Experience,
                ImageURL = updateAboutDto.ImageURL,
                Mail = updateAboutDto.Mail,
                Phone = updateAboutDto.Phone,
                SocialMedia = updateAboutDto.SocialMedia,
                Title1 = updateAboutDto.Title1,
                Title1Description = updateAboutDto.Title1Description,
                Title2 = updateAboutDto.Title2, 
                Title2Description = updateAboutDto.Title2Description,
                Title2MiniDescription = updateAboutDto.Title2MiniDescription
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value= _aboutService.TGetByID(id);
            return Ok(value);
        }   
    }
}
