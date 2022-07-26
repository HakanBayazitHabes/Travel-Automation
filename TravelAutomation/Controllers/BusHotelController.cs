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
    public class BusHotelController : Controller
    {
        // GET: BusHotel
        private IBusHotelService _busHotelManager;

        public BusHotelController()
        {
            _busHotelManager = InstanceFactory.GetInstance<IBusHotelService>();
        }

        public ActionResult Index()
        {
            var busHotelDegerler = _busHotelManager.GetAll();
            return View(busHotelDegerler);
        }
        [HttpGet]
        public ActionResult BusHotelEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BusHotelEkle(BusHotel busHotel)
        {
            _busHotelManager.Add(busHotel);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult HotelIptal(int id)
        {
            _busHotelManager.GetByDeleteIdHotel(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult BusIptal(int id)
        {
            _busHotelManager.GetByDeleteIdBus(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult BusHotelIptal(int id)
        {
            _busHotelManager.GetByDeleteBusHotel(id);
            Thread.Sleep(3100);
            return RedirectToAction("Index");
        }
        public ActionResult RaporlarinOlusturulmasiJSON()
        {
            var busHotelDeger = _busHotelManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiXML()
        {
            var busHotelDeger = _busHotelManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiHTML()
        {
            var busHotelDeger = _busHotelManager.GetAll();
            return View(busHotelDeger);
        }
    }
}