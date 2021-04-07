using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YemekTarifleriWeb.Data;
using YemekTarifleriWeb.Models;

namespace YemekTarifleriWeb.Controllers
{
    public class MealController : Controller
    {
        DataContext _context;
        public MealController(DataContext _context)
        {
            this._context = _context;
        }
        public IActionResult ViewMeal(int id)
        {
            List<Meal> mList = _context.Meals.Where(ct => ct.Kategori == id).ToList();
            List<TopCategory> tList = _context.TopCategories.ToList();
            List<Category> cList = _context.Categories.ToList();
            ViewBag.TopCategories = tList;
            foreach (var item in cList)
            {
                if (item.Id == id)
                {
                    ViewBag.Name = item.Ad;
                }
            }
            return View(mList);
        }
    }
}