using AjaxExample.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxExample.Controllers
{
    public class HomeController : Controller
    {
        Project3Entities db = new Project3Entities();
        public ActionResult Index()
        {
            return View(db.Calisans.ToList());
        }
        public ActionResult EmployeeInfo(int id)
        {
            List<Calisan> inf = db.Calisans.Where(x => x.calisanID == id).ToList();
            return View(inf);
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
    }
}