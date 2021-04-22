using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknolojiMarketimWithMvc.Models.Entity;
using TeknolojiMarketimWithMvc.ViewModels;

namespace TeknolojiMarketimWithMvc.Controllers
{
    public class SatinAlimController : Controller
    {
        // GET: SatinAlim
        Dbo_EticaretEntities7 db = new Dbo_EticaretEntities7();
        public ActionResult Index()
        {
            List<TBLSATINALIM> satinAlim = db.TBLSATINALIM.ToList();
            List<TBLMUSTERI> musteriler = db.TBLMUSTERI.ToList();
            List<TBLURUNLER> urunler = db.TBLURUNLER.ToList();

            var vm = from s in satinAlim
                     join m in musteriler on s.SATINALANMUSTERI equals m.MUSTERIID              
                     join u in urunler on s.SATILANURUN equals u.URUNID 
                     select new SatinAlimViewModel
                     {
                         satis=s,
                         urun = u,
                         musteri = m
                     };


            return View(vm);
        }

        public ActionResult SatinAlimAyrintilar(int id)
        {
            List<TBLSATINALIM> satinAlim = db.TBLSATINALIM.Where(m=>m.SATINALIMID==id).ToList();
            List<TBLMUSTERI> musteriler = db.TBLMUSTERI.ToList();
            List<TBLURUNLER> urunler = db.TBLURUNLER.ToList();

            var vm = from s in satinAlim
                     join m in musteriler on s.SATINALANMUSTERI equals m.MUSTERIID
                     join u in urunler on s.SATILANURUN equals u.URUNID
                     select new SatinAlimViewModel
                     {
                         urun = u,
                         musteri = m
                     };
            return View(vm);
        }
    }
}