using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using BusinessLayer.DependencyResolvers.Ninject;
using DataAccsessLayer.Concreate.EntityFramwork;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace TravelAutomation.Controllers
{
    public class BusTentController : Controller
    {
        // GET: BusTent
        private IBusTentService _busTentManager;

        public BusTentController()
        {
            _busTentManager = InstanceFactory.GetInstance<IBusTentService>();
        }
        
        public ActionResult Index()
        {
            var busTentDegerler = _busTentManager.GetAll();
            return View(busTentDegerler);
        }
        [HttpGet]
        public ActionResult BusTentEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BusTentEkle(BusTent busTent)
        {
            _busTentManager.Add(busTent);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult TentIptal(int id)
        {
            _busTentManager.GetByDeleteIdTent(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult BusIptal(int id)
        {
            _busTentManager.GetByDeleteIdBus(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult BusTentIptal(int id)
        {
            _busTentManager.GetByDeleteBusTent(id);
            Thread.Sleep(3100);
            return RedirectToAction("Index");
        }
        public ActionResult RaporlarinOlusturulmasiJSON()
        {
            var busHotelDeger = _busTentManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiXML()
        {
            var busHotelDeger = _busTentManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiHTML()
        {
            var busHotelDeger = _busTentManager.GetAll();
            return View(busHotelDeger);
        }

    }
}