using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TelApp.WebUI.Data;
using TelApp.WebUI.Model;

namespace TelApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
       {
            return View(CategoryRepository.Categories);
       }
    }
}