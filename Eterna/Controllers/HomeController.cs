using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services,
                Features = Data.Features,
                Sliders = Data.Sliders
        };
            return View(vm);
        }
    }
}
