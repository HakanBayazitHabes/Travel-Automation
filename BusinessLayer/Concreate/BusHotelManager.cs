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
    public class BusHotelManager : IBusHotelService
    {
        private IBusHotelDal _busHotelDal;

        public BusHotelManager(IBusHotelDal busHotelDal)
        {
            _busHotelDal = busHotelDal;
        }

        public void Add(BusHotel busHotel)
        {
            _busHotelDal.Add(busHotel);
        }

        public void Delete(BusHotel busHotel)
        {
            _busHotelDal.Delete(busHotel);
        }

        public List<BusHotel> GetAll()
        {
            return _busHotelDal.GetAll();
        }

        public void Update(BusHotel busHotel)
        {
            _busHotelDal.Update(busHotel);
        }

        public void GetByDeleteIdHotel(int id)
        {
            var hotelDeger = _busHotelDal.Get(x => x.ID == id);
            hotelDeger.IsDeleteHotel = "Delete";
            _busHotelDal.Update(hotelDeger);
        }

        public void GetByDeleteIdBus(int id)
        {
            var busDeger = _busHotelDal.Get(x => x.ID == id);
            busDeger.IsDeleteBus = "Delete";
            _busHotelDal.Update(busDeger);
        }

        public void GetByDeleteBusHotel(int id)
        {
            var busHotelDeger = _busHotelDal.Get(x => x.ID == id);
            busHotelDeger.IsDeleteHotel = "Delete";
            busHotelDeger.IsDeleteBus = "Delete";
            _busHotelDal.Update(busHotelDeger);
        }
    }
}
