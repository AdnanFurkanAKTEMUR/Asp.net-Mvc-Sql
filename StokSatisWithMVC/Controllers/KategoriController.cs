﻿using System;
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
            db.TBLKATEGORI.Add(p1);
            db.SaveChanges();

            return View();
        }
    }
}