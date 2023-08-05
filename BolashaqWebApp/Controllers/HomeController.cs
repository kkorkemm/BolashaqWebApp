using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BolashaqWebApp.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index(string title)
        {
            var list = AppData.GetContext().Kruzhok.ToList();
            if (!string.IsNullOrEmpty(title))
                list = list.Where(p => p.Name.Contains(title)).ToList();
            ViewBag.Courses = list;
            return View();
        }

        public ActionResult Kruzhok(int courseID)
        {
            ViewBag.Current = AppData.GetContext().Kruzhok.Where(p => p.ID == courseID).ToList().FirstOrDefault();
            return View();
        }

        public ActionResult Payment(int courseID)
        {
            ViewBag.Current = AppData.GetContext().Kruzhok.Where(p => p.ID == courseID).ToList().FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Payment(Zayavka zayavka)
        {
            try
            {
                AppData.GetContext().Zayavka.Add(zayavka);
                AppData.GetContext().SaveChanges();
                AppData.IsZayavka = true;
                AppData.NewZayavka = AppData.GetContext().Kruzhok.Where(p => p.ID == zayavka.KruzhokID).ToList().FirstOrDefault();
                return View("PaymentResult");
            }
            catch (Exception ex)
            {
                AppData.ErrorZayavka = ex.Message.ToString();
                AppData.IsZayavka = false;
                return View("PaymentResult");
            }
        }

        public ActionResult PaymentResult()
        {
            return View();
        }
    }
}