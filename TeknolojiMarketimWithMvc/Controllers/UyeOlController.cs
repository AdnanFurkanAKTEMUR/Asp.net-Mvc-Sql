using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiMarketimWithMvc.Models.Entity;

namespace TeknolojiMarketimWithMvc.Controllers
{
    public class UyeOlController : Controller
    {
        Dbo_EticaretEntities7 db = new Dbo_EticaretEntities7();
        // GET: UyeOl
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBLMUSTERI m1)
        {
            db.TBLMUSTERI.Add(m1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}