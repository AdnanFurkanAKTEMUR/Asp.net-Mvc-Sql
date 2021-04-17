using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TelApp.WebUI.Data;
using TelApp.WebUI.Model;
using TelApp.WebUI.ViewModels;

namespace TelApp.WebUI.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult List(){

            var productViewModel=new ProductViewModels(){
                products=ProductRepository.Products
            };
            return View(productViewModel);
        }

        public IActionResult Details(int id){
            return View(ProductRepository.GetProductById(id));
        }
    }
}