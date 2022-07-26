using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPlaneHotelService
    {
        List<PlaneHotel> GetAll();
        void Add(PlaneHotel planeHotel);
        void Update(PlaneHotel planeHotel);
        void Delete(PlaneHotel planeHotel);
        void GetByDeletePlaneHotel(int id);
        void GetByDeleteIdPlane(int id);
        void GetByDeleteIdHotel(int id);
    }
}
