using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBusTentService
    {
        List<BusTent> GetAll();
        void Add(BusTent busTent);
        void Delete(BusTent busTent);
        void Update(BusTent busTent);
        void GetByDeleteBusTent(int id);
        void GetByDeleteIdBus(int id);
        void GetByDeleteIdTent(int id);
    }
}
