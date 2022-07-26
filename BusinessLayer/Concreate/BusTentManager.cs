using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class BusTentManager : IBusTentService
    {
        private IBusTentDal _busTentDal;

        public BusTentManager(IBusTentDal busTentDal)
        {
            _busTentDal = busTentDal;
        }

        public void Add(BusTent busTent)
        {
            _busTentDal.Add(busTent);
        }

        public void Delete(BusTent busTent)
        {
            _busTentDal.Delete(busTent);
        }

        public List<BusTent> GetAll()
        {
            return _busTentDal.GetAll();
        }

        public void Update(BusTent busTent)
        {
            _busTentDal.Update(busTent);
        }

        public void GetByDeleteIdTent(int id)
        {
            var tentDeger = _busTentDal.Get(x => x.ID == id);
            tentDeger.IsDeleteTent = "Delete";
            _busTentDal.Update(tentDeger);
        }

        public void GetByDeleteIdBus(int id)
        {
            var busDeger = _busTentDal.Get(x => x.ID == id);
            busDeger.IsDeleteBus = "Delete";
            _busTentDal.Update(busDeger);
        }

        public void GetByDeleteBusTent(int id)
        {
            var busHotelDeger = _busTentDal.Get(x => x.ID == id);
            busHotelDeger.IsDeleteTent = "Delete";
            busHotelDeger.IsDeleteBus = "Delete";
            _busTentDal.Update(busHotelDeger);
        }
    }
}
