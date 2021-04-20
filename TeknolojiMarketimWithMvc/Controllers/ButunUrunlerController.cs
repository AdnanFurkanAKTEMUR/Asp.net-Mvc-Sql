using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiMarketimWithMvc.Models.Entity;
using TeknolojiMarketimWithMvc.ViewModels;

namespace TeknolojiMarketimWithMvc.Controllers
{
    public class ButunUrunlerController : Controller
    {
        // GET: ButunUrunler
        Dbo_EticaretEntities7 db = new Dbo_EticaretEntities7();
        public ActionResult Index()
        {
            
            var urunler = db.TBLURUNLER.ToList();
            return View(urunler);
        }

        public ActionResult UrunAyrintilari(int urunId=1)
        {
            
            var urun = db.TBLURUNLER.Where(m => m.URUNID == urunId).ToList();
            var yorum = db.TBLYORUM.Where(m => m.YORUNURUN == urunId).ToList();
            var urunViewModel = new UrunViewModel
            {
                urun = urun,
                yorumlar = yorum
            };
            

            return View(urunViewModel);
        }
    }
}