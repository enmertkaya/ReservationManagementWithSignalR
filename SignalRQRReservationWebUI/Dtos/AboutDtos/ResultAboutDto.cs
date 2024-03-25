using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservationWebUI.Dtos.AboutDtos
{
    public class ResultAboutDto
    {
        public int AboutID { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Title2Description { get; set; }
        public string Title2MiniDescription { get; set; }
        public string Title1Description { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Education { get; set; }
        public string Mail { get; set; }
        public string Experience { get; set; }
    }
}
