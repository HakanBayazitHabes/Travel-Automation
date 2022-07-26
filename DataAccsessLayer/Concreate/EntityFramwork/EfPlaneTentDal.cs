using DataAccsessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concreate.EntityFramwork
{
    public class EfPlaneTentDal :EfEntityRepositoryBase<PlaneTent ,Context>,IPlaneTentDal
    {
    }
}
