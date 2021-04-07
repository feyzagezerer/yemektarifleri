using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YemekTarifleriWeb.Data;
using YemekTarifleriWeb.Models;

namespace YemekTarifleriWeb.Controllers
{
    public class MealDetailController : Controller
    {

        DataContext _context;

        public MealDetailController(DataContext _context)
        {
            this._context = _context;
        }
        public IActionResult ViewMealDetail(int id)
        {
            Meal cMeal = new Meal();
            List<Meal> meals = _context.Meals.ToList();
            foreach (Meal m in meals)
            {
                if (m.Id == id)
                {
                    cMeal = m;
                }
            }
            List<Meal> mMeals = new List<Meal>();
            mMeals.Add(cMeal);
            foreach (Meal item in meals)
            {
                if (cMeal.Kategori == item.Kategori && cMeal.Id != item.Id)
                {
                    mMeals.Add(item);
                }
            }
            List<TopCategory> tList = _context.TopCategories.ToList();
            ViewBag.TopCategories = tList;
            return View(mMeals);
        }
    }
}