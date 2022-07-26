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
    public class PlaneHotelController : Controller
    {
        // GET: PlaneHotel
        private IPlaneHotelService _planeHotelManager;

        public PlaneHotelController()
        {
            _planeHotelManager = InstanceFactory.GetInstance<IPlaneHotelService>();
        }

        public ActionResult Index()
        {
            var planeHoteldegerler = _planeHotelManager.GetAll();
            return View(planeHoteldegerler);
        }
        [HttpGet]
        public ActionResult UcakHotelAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UcakHotelAdd(PlaneHotel planeHotel)
        {
            _planeHotelManager.Add(planeHotel);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }

        public ActionResult HotelIptal(int id)
        {
            _planeHotelManager.GetByDeleteIdHotel(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult PlaneIptal(int id)
        {
            _planeHotelManager.GetByDeleteIdPlane(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult PlaneHotelIptal(int id)
        {
            _planeHotelManager.GetByDeletePlaneHotel(id);
            Thread.Sleep(3100);
            return RedirectToAction("Index");
        }
        public ActionResult RaporlarinOlusturulmasiJSON()
        {
            var busHotelDeger = _planeHotelManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiXML()
        {
            var busHotelDeger = _planeHotelManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiHTML()
        {
            var busHotelDeger = _planeHotelManager.GetAll();
            return View(busHotelDeger);
        }

    }
}