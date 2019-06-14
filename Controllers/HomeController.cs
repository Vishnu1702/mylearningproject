using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MAADISWEETS.Models;
using MAADISWEETS.HomeViewModel;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISweetRepository _sweetRepository;

        public HomeController(ISweetRepository sweetRepository)
        {
            _sweetRepository = sweetRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Sweet Shop";

            var sweets = _sweetRepository.getAllSweet().OrderBy(p => p.SweetName);

            var homeViewModel = new HomeViewModel(){
                Title = "Maadi Sweet Shop",
                Sweets = sweets.ToList()
            };

            return View(homeViewModel);
        }   
         
    }
}
