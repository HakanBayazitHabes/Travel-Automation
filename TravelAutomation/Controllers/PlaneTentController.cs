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
    public class PlaneTentController : Controller
    {
        // GET: PlaneTent
        private IPlaneTentService _planeTentManager;

        public PlaneTentController()
        {
            _planeTentManager = InstanceFactory.GetInstance<IPlaneTentService>();
        }

        public ActionResult Index()
        {
            var planeTentDegerler = _planeTentManager.GetAll();
            return View(planeTentDegerler);
        }
        [HttpGet]
        public ActionResult UcakCadirAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UcakCadirEkle(PlaneTent planeTent)
        {
            _planeTentManager.Add(planeTent);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult CadirIptal(int id)
        {
            _planeTentManager.GetByDeleteIdCadir(id);  
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult PlaneIptal(int id)
        {
            _planeTentManager.GetByDeleteIdPlane(id);
            Thread.Sleep(2700);
            return RedirectToAction("Index");
        }
        public ActionResult PlaneCadirIptal(int id)
        {
            _planeTentManager.GetByDeletePlanecadir(id);
            Thread.Sleep(3100);
            return RedirectToAction("Index");
        }
        public ActionResult RaporlarinOlusturulmasiJSON()
        {
            var busHotelDeger = _planeTentManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiXML()
        {
            var busHotelDeger = _planeTentManager.GetAll();
            return View(busHotelDeger);
        }
        public ActionResult RaporlarinOlusturulmasiHTML()
        {
            var busHotelDeger = _planeTentManager.GetAll();
            return View(busHotelDeger);
        }
    }
}