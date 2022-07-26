using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concreate.EntityFramwork
{
    public class Context:DbContext
    {
        public DbSet<PlaneTent> Ucaks { get; set; }
        public DbSet<BusHotel> Otobuss { get; set; }
        public DbSet<PlaneHotel> Otels { get; set; }
        public DbSet<BusTent> Cadırs { get; set; }
    }
}
