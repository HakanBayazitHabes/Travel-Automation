using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBusHotelService
    {
        List<BusHotel> GetAll();
        void Add(BusHotel busHotel);
        void Update(BusHotel busHotel);
        void Delete(BusHotel busHotel);
        void GetByDeleteIdHotel(int id);
        void GetByDeleteIdBus(int id);
        void GetByDeleteBusHotel(int id);
    }
}
