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
        public ActionResult Sil(int id)
        {
            var silinecekMusteri = db.TBLMUSTERI.Find(id);
            db.TBLMUSTERI.Remove(silinecekMusteri);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult MusteriGetir(int id)
        {
            var musteri = db.TBLMUSTERI.Find(id);
            return View("MusteriGetir", musteri);
        }

        public ActionResult Guncelle(TBLMUSTERI p1)
        {
            var musteri = db.TBLMUSTERI.Find(p1.MUSTERIID);
            musteri.MUSTERIAD = p1.MUSTERIAD;
            musteri.MUSTERISOYAD = p1.MUSTERISOYAD;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}