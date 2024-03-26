using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRQRReservation.BusinessLayer.Abstract;
using SignalRQRReservation.DtoLayer.CategoryDto;
using SignalRQRReservation.DtoLayer.HomePageDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        private readonly IHomePageService _homePageService;
        private readonly IMapper _mapper;

        public HomePageController(IHomePageService homePageService, IMapper mapper)
        {
            _homePageService = homePageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult HomePageList ()
        {
            var value = _mapper.Map<List<ResultHomePageDto>>(_homePageService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateHomePage (CreateHomePageDto createHomePageDto)
        {
            _homePageService.TAdd(new HomePage()
            {
                Descripton1 = createHomePageDto.Descripton1,
                Descripton2 = createHomePageDto.Descripton2,
                Descripton3 = createHomePageDto.Descripton3,
                Title1 = createHomePageDto.Title1,
                Title2 = createHomePageDto.Title2,
                Title3 = createHomePageDto.Title3

            });
            return Ok("Ana Sayfa eklendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetHomePage (int id)
        {
            var value=_homePageService.TGetByID(id);
            return Ok(value);   
        }

        [HttpPut]
        public IActionResult UpdateHomePage ( UpdateHomePageDto updateHomePageDto)
        {
            _homePageService.TUpdate(new HomePage()
            {
                FeatureID = updateHomePageDto.FeatureID,
                Descripton1 = updateHomePageDto.Descripton1,
                Descripton2 = updateHomePageDto.Descripton2,
                Descripton3 = updateHomePageDto.Descripton3,
                Title1 = updateHomePageDto.Title1,
                Title2 = updateHomePageDto.Title2,
                Title3 = updateHomePageDto.Title3
            });
            return Ok("Ana sayfa güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHomePage (int id)
        {
            var value=_homePageService.TGetByID(id);
            _homePageService.TDelete(value);
            return Ok("Ana sayfa bilgisi silindi");
        }
    }
}
