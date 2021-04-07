using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YemekTarifleriWeb.Data;
using YemekTarifleriWeb.Models;
namespace YemekTarifleriWeb.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;

        public HomeController(DataContext _context)
        {
            this._context = _context;
        }
        public IActionResult Index()
        {
            List<TopCategory> topCategoryList = _context.TopCategories.ToList();
            List<Meal> mealList = _context.Meals.ToList();
            ViewBag.TopCategories = topCategoryList;
            ViewBag.Meals = mealList;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
