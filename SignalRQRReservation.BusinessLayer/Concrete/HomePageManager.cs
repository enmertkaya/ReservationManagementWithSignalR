using SignalRQRReservation.BusinessLayer.Abstract;
using SignalRQRReservation.DataAccessLayer.Abstract;
using SignalRQRReservation.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRQRReservation.BusinessLayer.Concrete
{
    public class HomePageManager : IHomePageService
    {
        private readonly IHomePageDal _homePageDal;

        public HomePageManager(IHomePageDal homePageDal)
        {
            _homePageDal = homePageDal;
        }

        public void TAdd(HomePage entity)
        {
            _homePageDal.Add(entity);
        }

        public void TDelete(HomePage entity)
        {
            _homePageDal.Delete(entity);
        }

        public HomePage TGetByID(int id)
        {
            return _homePageDal.GetByID(id);
        }

        public List<HomePage> TGetListAll()
        {
            return _homePageDal.GetListAll();
        }

        public void TUpdate(HomePage entity)
        {
            _homePageDal.Update(entity);
        }
    }
}
