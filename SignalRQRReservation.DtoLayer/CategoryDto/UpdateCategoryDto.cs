﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.DtoLayer.CategoryDto
{
    public class UpdateCategoryDto
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
