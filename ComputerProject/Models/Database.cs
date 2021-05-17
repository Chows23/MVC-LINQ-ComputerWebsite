using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerProject.Models
{
    public class Database
    {
        public List<Laptop> Laptops { get; set; }
        public List<Brand> Brands { get; set; }
        public Database()
        {
            Brands = new List<Brand>();
            var brand1 = new Brand("ASUS");
            var brand2 = new Brand("APPLE");
            var brand3 = new Brand("DELL");
            Brands.Add(brand1); Brands.Add(brand2); Brands.Add(brand3);


            Laptops = new List<Laptop>();
            var lap1 = new Laptop(1, brand1, 200);
            var lap2 = new Laptop(2, brand2, 250);
            var lap3 = new Laptop(3, brand3, 400);
            var lap4 = new Laptop(4, brand1, 350);
            var lap5 = new Laptop(5, brand2, 450);
            Laptops.Add(lap1); Laptops.Add(lap2); Laptops.Add(lap3); Laptops.Add(lap4); Laptops.Add(lap5);


            brand1.Laptops.Add(lap1);brand1.Laptops.Add(lap4);
            brand2.Laptops.Add(lap2); brand2.Laptops.Add(lap5);
            brand3.Laptops.Add(lap3);
        }

    }
}
