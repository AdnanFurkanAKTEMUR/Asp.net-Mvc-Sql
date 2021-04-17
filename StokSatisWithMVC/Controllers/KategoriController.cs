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
    }
}