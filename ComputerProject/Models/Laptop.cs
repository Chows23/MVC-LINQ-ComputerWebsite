using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerProject.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public double Price { get; set; }

        public Laptop(int id, Brand brand, double price)
        {
            this.Id = id;
            this.Brand = brand;
            this.Price = price;
        }
    }
}
