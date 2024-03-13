﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.DtoLayer.ChangeDto
{
    public class CreateChangeDto
    {
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ImageURL { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
