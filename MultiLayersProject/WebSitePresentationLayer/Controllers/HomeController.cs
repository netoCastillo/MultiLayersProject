using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSitePresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Employee()
        {            
            List<DataLayer.Empleado> empleados = BusinessLayer.Employe.Get();            
            return View(empleados);
        }

        public ActionResult EmployeePage(int indexPage = 0)
        {
            ViewBag.TotalItems = BusinessLayer.Employe.Get().Count;
            ViewBag.SizePage = 5;
            ViewBag.IndexSelected = indexPage;
            List<EntityLayer.EmployeeEntity> employees = BusinessLayer.Employe.GetByPage(indexPage);
            return View(employees);
        }


    }
}