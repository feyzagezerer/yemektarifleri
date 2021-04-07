using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YemekTarifleriWeb.Data;
using YemekTarifleriWeb.Models;

namespace YemekTarifleriWeb.Controllers
{
    public class CategoryController : Controller
    {

        DataContext _context;
        public CategoryController(DataContext _context)
        {
            this._context = _context;
        }

        public IActionResult ViewCategory(int id)
        {
            List<Category> cList = _context.Categories.Where(ct => ct.KategoriId == id).ToList();
            List<TopCategory> tList = _context.TopCategories.ToList();
            ViewBag.TopCategories = tList;
            foreach (var item in tList)
            {
                if (item.Id == id)
                {
                    ViewBag.Name = item.Ad;
                }
            }
            return View(cList);
        }
    }
}