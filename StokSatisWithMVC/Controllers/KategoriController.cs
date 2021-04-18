using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokSatisWithMVC.Models.Entity;

namespace StokSatisWithMVC.Controllers
{
    public class KategoriController : Controller
    {
        Dbo_MvcStokEntities db = new Dbo_MvcStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORI.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORI p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
         
            }
            db.TBLKATEGORI.Add(p1);
            db.SaveChanges();
               
            return View();
        }

        public ActionResult Sil(int id)
        {
            var kategori = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GUNCELLE(int id)
        {
            var guncellenecek = db.TBLKATEGORI.Find(id);


            return View("GUNCELLE",guncellenecek);
        }

        public ActionResult Guncellendi(TBLKATEGORI p1)
        {
            var ktg = db.TBLKATEGORI.Find(p1.KATEGORIID);
            ktg.KATEGORINAME = p1.KATEGORINAME;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}