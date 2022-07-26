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
    public class PlaneTentManager : IPlaneTentService
    {
        private IPlaneTentDal _planeTentDal;

        public PlaneTentManager(IPlaneTentDal planeTentDal)
        {
            _planeTentDal = planeTentDal;
        }

        public void Add(PlaneTent planeTent)
        {
            _planeTentDal.Add(planeTent);
        }

        public void Delete(PlaneTent planeTent)
        {
            _planeTentDal.Delete(planeTent);
        }

        public List<PlaneTent> GetAll()
        {
            return _planeTentDal.GetAll();
        }

        public void Update(PlaneTent planeTent)
        {
            _planeTentDal.Update(planeTent);
        }
        public void GetByDeleteIdCadir(int id)
        {
            var cadirDeger = _planeTentDal.Get(x => x.ID == id);
            cadirDeger.IsDeleteCadir = "Delete";
            _planeTentDal.Update(cadirDeger);
        }

        public void GetByDeleteIdPlane(int id)
        {
            var ucakDeger = _planeTentDal.Get(x => x.ID == id);
            ucakDeger.IsDeletePlane = "Delete";
            _planeTentDal.Update(ucakDeger);
        }

        public void GetByDeletePlanecadir(int id)
        {
            var ucakCadirDeger = _planeTentDal.Get(x => x.ID == id);
            ucakCadirDeger.IsDeletePlane = "Delete";
            ucakCadirDeger.IsDeleteCadir = "Delete";
            _planeTentDal.Update(ucakCadirDeger);
        }
    }
}
