using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DTO
{
    internal class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductDTO(string Name, double Price) 
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
