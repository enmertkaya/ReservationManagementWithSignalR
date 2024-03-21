using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.DtoLayer.ChangeDto
{
    public class ResultChangeWithCategory
    {
        public int ChangeID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
		public bool ChangeStatus { get; set; }
	}
}
