using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiMarketimWithMvc.Models.Entity;

namespace TeknolojiMarketimWithMvc.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        Dbo_EticaretEntities7 db = new Dbo_EticaretEntities7();
        public ActionResult Index(int id=1)
        {
            var urunler = db.TBLURUNLER.Where(m => m.URUNKATEGORI == id).ToList();
            return View(urunler);
        }
    }
}