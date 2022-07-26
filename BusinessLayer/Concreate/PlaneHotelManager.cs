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
    public class PlaneHotelManager : IPlaneHotelService
    {
        private IPlaneHotelDal _planeHotelDal;

        public PlaneHotelManager(IPlaneHotelDal planeHotelDal)
        {
            _planeHotelDal = planeHotelDal;
        }

        public void Add(PlaneHotel planeHotel)
        {
            _planeHotelDal.Add(planeHotel);
        }

        public void Delete(PlaneHotel planeHotel)
        {
            _planeHotelDal.Delete(planeHotel);
        }

        public List<PlaneHotel> GetAll()
        {
            return _planeHotelDal.GetAll();
        }

        public void Update(PlaneHotel planeHotel)
        {
            _planeHotelDal.Update(planeHotel);
        }

        public void GetByDeleteIdHotel(int id)
        {
            var hotelDeger = _planeHotelDal.Get(x => x.ID == id);
            hotelDeger.IsDeleteHotel = "Delete";
            _planeHotelDal.Update(hotelDeger);
        }

        public void GetByDeleteIdPlane(int id)
        {
            var deger = _planeHotelDal.Get(x => x.ID == id);
            deger.IsDeletePlane = "Delete";
            _planeHotelDal.Update(deger);
        }

        public void GetByDeletePlaneHotel(int id)
        {
            var deger = _planeHotelDal.Get(x => x.ID == id);
            deger.IsDeleteHotel = "Delete";
            deger.IsDeletePlane = "Delete";
            _planeHotelDal.Update(deger);
        }
    }
}
