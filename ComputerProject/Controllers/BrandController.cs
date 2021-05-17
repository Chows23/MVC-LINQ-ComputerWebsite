using ComputerProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerProject.Controllers
{
    public class BrandController : Controller
    {
        Database db = new Database();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            var res = from brand in db.Brands
                      select brand.BrandName;
            return View(res.ToList());
        }

        public IActionResult MostExpensiveBrand()
        {
            var res = (from laptop in db.Laptops
                      orderby laptop.Price descending
                      select laptop.Brand).FirstOrDefault();
            return View(res);
        }

        public IActionResult CompareLaptop(int id1, int id2)
        {
            var res = (from laptop in db.Laptops
                      where laptop.Id == id1 || laptop.Id == id2
                      select laptop).ToList();
            return View(res);
        }

        public IActionResult ShowBrandsAnyLaptopsLessN(double n)
        {
            ViewBag.n = n;
            var res = db.Brands.Where(b => b.Laptops.Any(lap => lap.Price < n)).ToList();
            return View(res);
        }

        public IActionResult ShowLaptopInEachBrand()
        {
            var res = db.Laptops.GroupBy(lap => lap.Brand);
            return View(res);
        }
    }
}
