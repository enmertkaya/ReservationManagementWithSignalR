﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRQRReservation.BusinessLayer.Abstract;
using SignalRQRReservation.DataAccessLayer.Concrete;
using SignalRQRReservation.DtoLayer.CategoryDto;
using SignalRQRReservation.DtoLayer.ChangeDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeController : ControllerBase
    {
        private readonly IChangeService _changeService;
        private readonly IMapper _mapper;

        public ChangeController(IChangeService changeService, IMapper mapper)
        {
            _changeService = changeService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ChangeList()
        {
            var value = _mapper.Map<List<ResultChangeDto>>(_changeService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateChange(CreateChangeDto createChangeDto)
        {
            _changeService.TAdd(new Change()
            {
                Date = createChangeDto.Date,
                Description = createChangeDto.Description,
                ImageURL = createChangeDto.ImageURL,
                Title1 = createChangeDto.Title1,
                Title2 = createChangeDto.Title2,
                CategoryID = createChangeDto.CategoryID
                
               
            });
            return Ok("Degisim Eklendi");
        }

        [HttpPut]
        public IActionResult UpdateChange(UpdateChangeDto updateChangeDto)
        {
            _changeService.TUpdate(new Change()
            {
                CategoryID = updateChangeDto.CategoryID,
                ChangeID = updateChangeDto.ChangeID,
                Description = updateChangeDto.Description,
                Date = updateChangeDto.Date,
                ImageURL = updateChangeDto.ImageURL,
                Title1 = updateChangeDto.Title1,
                Title2 = updateChangeDto.Title2

            });
            return Ok("Değişim Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteChange(int id)
        {
            var value= _changeService.TGetByID(id);
            _changeService.TDelete(value);
            return Ok("Degişim Sİlindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetChange (int id)
        {
            var value=_changeService.TGetByID(id);
            return  Ok(value);
        }

        [HttpGet("ChangeListWithCategory")]
        public IActionResult ChangeListWithCategory ()
        {
            var context = new SignalRQRReservationContext();
            var values = context.Changes.Include(x => x.Category).Select(y => new ResultChangeWithCategoryDto
            {
                CategoryName = y.Category.CategoryName,
                Date = y.Date,
                ChangeID= y.ChangeID,
                Description = y.Description,
                ImageURL= y.ImageURL,
                Title1 =y.Title1,
                Title2 =y.Title2
            });
            return Ok(values.ToList());
        }


    }
}
