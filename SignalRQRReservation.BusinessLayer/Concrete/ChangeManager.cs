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
    public class ChangeManager : IChangeService
    {
        private readonly IChangeDal _changeDal;

        public ChangeManager(IChangeDal changeDal)
        {
            _changeDal = changeDal;
        }

        public void TAdd(Change entity)
        {
            _changeDal.Add(entity);
        }

        public void TDelete(Change entity)
        {
            _changeDal.Delete(entity);
        }

        public Change TGetByID(int id)
        {
            return _changeDal.GetByID(id);
        }

        public List<Change> TGetListAll()
        {
            return _changeDal.GetListAll();
        }

        public void TUpdate(Change entity)
        {
            _changeDal.Update(entity);
        }
    }
}
