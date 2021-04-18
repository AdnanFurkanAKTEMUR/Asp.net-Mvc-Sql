using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokSatisWithMVC.Models.Entity;

namespace StokSatisWithMVC.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        Dbo_MvcStokEntities db = new Dbo_MvcStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERI.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMusteriEkle(TBLMUSTERI p1)
        {
            db.TBLMUSTERI.Add(p1);
            db.SaveChanges();

            return View();
        }
    }
}