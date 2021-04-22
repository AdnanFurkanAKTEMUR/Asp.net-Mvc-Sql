using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeknolojiMarketimWithMvc.Models.Entity;

namespace TeknolojiMarketimWithMvc.ViewModels
{
    public class SatinAlimViewModel
    {
        public TBLSATINALIM satis { get; set; }
        public TBLMUSTERI musteri { get; set; }
        public TBLURUNLER urun { get; set; }
    }
}