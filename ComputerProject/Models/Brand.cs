using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerProject.Models
{
    public class Brand
    {
        public string BrandName { get; set; }
        public List<Laptop> Laptops { get; set; }
        public Brand(string name)
        {
            this.BrandName = name;
            this.Laptops = new List<Laptop>();
        }

    }
}
