using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TelApp.WebUI.Data;
using TelApp.WebUI.Model;
using TelApp.WebUI.ViewModels;

namespace TelApp.WebUI.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            
            var product=new ProductViewModels(){
                products=ProductRepository.Products
            };
            return View(product);
        }

        public IActionResult About(){
            return View();
        }

        public IActionResult Contact(){
            return View();
        }
    }
}