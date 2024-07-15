using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Smart_Cart
{
    public enum ProductCategory
    {
        MenClothes,
        WomenClothes,
        Kids,
        Home
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }
        //public Product(string name, ProductCategory category ){}

    }

}
