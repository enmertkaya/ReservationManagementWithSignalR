using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservationWebUI.Dtos.BookingDtos
{
    public class CreateBookingDto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string MyMail { get; set; }
        public string MyPhone { get; set; }
        public string MyLocation { get; set; }
        public string Description { get; set; }
    }
}
