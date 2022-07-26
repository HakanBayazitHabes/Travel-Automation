using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPlaneTentService
    {
        List<PlaneTent> GetAll();
        void Add(PlaneTent planeTent);
        void Delete(PlaneTent planeTent);
        void Update(PlaneTent planeTent);
        void GetByDeletePlanecadir(int id);
        void GetByDeleteIdPlane(int id);
        void GetByDeleteIdCadir(int id);
    }
}
