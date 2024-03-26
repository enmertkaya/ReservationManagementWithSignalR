using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRQRReservation.BusinessLayer.Abstract;
using SignalRQRReservation.DataAccessLayer.Abstract;
using SignalRQRReservation.DtoLayer.BookingDto;
using SignalRQRReservation.EntityLayer.Entities;

namespace SignalRQRReservationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList ()
        {
            var values= _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking (CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Description = createBookingDto.Description,
                Message = createBookingDto.Message,
                Mail = createBookingDto.Mail,
                MyLocation = createBookingDto.MyLocation,
                MyMail = createBookingDto.MyMail,
                MyPhone = createBookingDto.MyPhone,
                Name = createBookingDto.Name,
                Subject = createBookingDto.Subject
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Başarıyla Eklendi");
        }

        [HttpGet("{id}")]
        public IActionResult  GetBooking ( int id)
        {
            var value=_bookingService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBooking (UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingID=updateBookingDto.BookingID,
                Description = updateBookingDto.Description,
                Message = updateBookingDto.Message,
                Mail = updateBookingDto.Mail,
                MyLocation = updateBookingDto.MyLocation,
                MyMail = updateBookingDto.MyMail,
                MyPhone = updateBookingDto.MyPhone,
                Name = updateBookingDto.Name,
                Subject = updateBookingDto.Subject
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon alanı güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking (int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }

    }
}
