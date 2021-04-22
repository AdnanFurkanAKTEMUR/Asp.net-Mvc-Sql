using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiMarketimWithMvc.Models.Entity;

namespace TeknolojiMarketimWithMvc.Controllers
{
    public class SatinAlController : Controller
    {
        // GET: SatinAl
        Dbo_EticaretEntities7 db = new Dbo_EticaretEntities7();

        [HttpGet]
        public ActionResult Index(int id)
        {
            var urun = db.TBLURUNLER.Where(m => m.URUNID == id).ToList();
            
            return View(urun);
        }

        [HttpPost]
        public ActionResult Index(int urunid,int musteriid)
        {
            
            var urun = db.TBLURUNLER.Find(urunid);
            urun.STOK = urun.STOK - 1;
            db.Entry(urun).State = EntityState.Modified;
            db.SaveChanges();

            TBLSATINALIM yeni = new TBLSATINALIM();
            yeni.SATILANURUN = urunid;
            yeni.SATINALANMUSTERI = musteriid;
            db.TBLSATINALIM.Add(yeni);
            db.SaveChanges();

            return RedirectToAction("Thx");
        }
        public ActionResult Thx()
        {
            return View();
        }
    }
}