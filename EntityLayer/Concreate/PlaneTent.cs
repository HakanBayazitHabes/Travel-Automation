using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class PlaneTent:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public DateTime CadirGirisTarihi { get; set; }
        public DateTime CadirÇıkışTarihi { get; set; }
        public string Lokasyon { get; set; }
        public int CadirSayisi { get; set; }
        public int CadirFiyat { get; set; }
        public DateTime GidişTarihi { get; set; }
        public DateTime DönüşTarihi { get; set; }
        public int PlaneFiyat { get; set; }
        public int BiletSayısı { get; set; }
        public string KalkışLokasyonu { get; set; }
        public string VarışLokasyonu { get; set; }
        public string IsDeleteCadir { get; set; }
        public string IsDeletePlane { get; set; }
    }
}
