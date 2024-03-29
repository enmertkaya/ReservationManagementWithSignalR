﻿using SignalRQRReservation.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.DataAccessLayer.Abstract
{
    public interface IChangeDal : IGenericDal <Change>
    {
        List<Change> GetChangeWithCategories();
    }
}
