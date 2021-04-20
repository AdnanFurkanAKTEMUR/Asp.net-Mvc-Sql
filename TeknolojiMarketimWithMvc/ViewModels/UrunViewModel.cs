using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeknolojiMarketimWithMvc.Models.Entity;

namespace TeknolojiMarketimWithMvc.ViewModels
{
    public class UrunViewModel
    {
        public List<TBLURUNLER> urun { get; set; }
        public List<TBLYORUM> yorumlar { get; set; }
    }
}