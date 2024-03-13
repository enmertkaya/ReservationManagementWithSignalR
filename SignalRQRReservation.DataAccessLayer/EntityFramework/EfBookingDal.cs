using SignalRQRReservation.DataAccessLayer.Abstract;
using SignalRQRReservation.DataAccessLayer.Concrete;
using SignalRQRReservation.DataAccessLayer.Repositories;
using SignalRQRReservation.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking> , IBookingDal
    {
        public EfBookingDal(SignalRQRReservationContext context) : base(context)
        {
        }
    }
}
