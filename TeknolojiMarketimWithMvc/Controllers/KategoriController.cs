using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiMarketimWithMvc.Models.Entity;

namespace TeknolojiMarketimWithMvc.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Dbo_EticaretEntities7 db = new Dbo_EticaretEntities7();
        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORI.ToList();
            return View(degerler);
        }
    }
}