﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservationWebUI.Dtos.TestimonialDtos
{
    public class CreateTestimonialDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
