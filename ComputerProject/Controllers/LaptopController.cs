using ComputerProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerProject.Controllers
{
    public class LaptopController : Controller
    {
        Database db = new Database();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowMostExpensive()
        {
            var maxPrice = db.Laptops.Max(lap => lap.Price);
            var res = db.Laptops.FirstOrDefault(lap => lap.Price == maxPrice);
            return View(res);
        }

        public IActionResult ShowMostExpensiveTwo()
        {
            var res = db.Laptops.OrderByDescending(lap => lap.Price)
                .Take(2).ToList();
            return View(res);
        }

        public IActionResult ShowCheapestThree()
        {
            var res = db.Laptops.OrderBy(lap => lap.Price)
                .Take(3).ToList();
            return View(res);
        }

        public IActionResult GetAllLaptops(double money)
        {
            var res = db.Laptops.Where(lap => lap.Price <= money).ToList();
            return View(res);
        }
    }
}
