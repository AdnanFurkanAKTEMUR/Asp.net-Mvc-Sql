﻿using System;
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

        [HttpGet]
        public ActionResult URUNAYRINTI(int id)
        {
            var urun = db.TBLURUNLER.Where(m => m.URUNID == id).ToList();
            var yorum = db.TBLYORUM.Where(m => m.YORUNURUN == id).ToList();
            var urunViewModel = new UrunViewModel
            {
                urun = urun,
                yorumlar = yorum
            };


            return View("URUNAYRINTI", urunViewModel);
        }
        
        [HttpPost]
        public ActionResult URUNAYRINTI(TBLYORUM p1)
        {
            db.TBLYORUM.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        /*
        public ActionResult UrunAyrintilari(int urunId)
        {

            var urun = db.TBLURUNLER.Where(m => m.URUNID == urunId).ToList();
            var yorum = db.TBLYORUM.Where(m => m.YORUNURUN == urunId).ToList();
            var urunViewModel = new UrunViewModel
            {
                urun = urun,
                yorumlar = yorum
            };


            return View ("UrunAyrintilari",urunViewModel);
        }


        
        /*public ActionResult UrunAyrintilari(TBLYORUM p1)
        {
            db.TBLYORUM.Add(p1);
            db.SaveChanges();
            /*var urun = db.TBLURUNLER.Where(m => m.URUNID == p1.YORUNURUN).ToList();
            var yorum = db.TBLYORUM.Where(m => m.YORUNURUN == p1.YORUNURUN).ToList();
            var urunViewModel = new UrunViewModel
            {
                urun = urun,
                yorumlar = yorum
            };
            return View(urunViewModel);
            return RedirectToAction("Index");
        }*/
    }
}