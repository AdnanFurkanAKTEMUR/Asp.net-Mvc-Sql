using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokSatisWithMVC.Models.Entity;

namespace StokSatisWithMVC.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Dbo_MvcStokEntities db = new Dbo_MvcStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniUrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.TBLKATEGORI.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORINAME,
                                                 Value = i.KATEGORIID.ToString()
                                             }
                                             ).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult YeniUrunEkle(TBLURUNLER p1)
        {
            db.TBLURUNLER.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}