using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class BusHotel : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public DateTime HotelGirişTarihi { get; set; }
        public DateTime HotelÇıkışTarihi { get; set; }
        public string Lokasyon { get; set; }
        public int OdaSayisi { get; set; }
        public int HotelFiyat { get; set; }
        public int BusFiyat { get; set; }
        public int BusBiletSayısı { get; set; }
        public DateTime OtobusGidişTarihi { get; set; }
        public DateTime OtobusDönüşTarihi { get; set; }
        public string KalkışLokasyonu { get; set; }
        public string VarışLokasyonu { get; set; }
        public string IsDeleteHotel { get; set; }
        public string IsDeleteBus { get; set; }
    }
}
