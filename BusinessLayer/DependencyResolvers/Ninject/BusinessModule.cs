using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concreate.EntityFramwork;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBusHotelService>().To<BusHotelManager>().InSingletonScope();
            Bind<IBusHotelDal>().To<EfBusHotelDal>().InSingletonScope();

            Bind<IBusTentService>().To<BusTentManager>().InSingletonScope();
            Bind<IBusTentDal>().To<EfBusTentDal>().InSingletonScope();
            
            Bind<IPlaneHotelService>().To<PlaneHotelManager>().InSingletonScope();
            Bind<IPlaneHotelDal>().To<EfPlaneHotelDal>().InSingletonScope();

            Bind<IPlaneTentService>().To<PlaneTentManager>().InSingletonScope();
            Bind<IPlaneTentDal>().To<EfPlaneTentDal>().InSingletonScope();

        }
    }
}
