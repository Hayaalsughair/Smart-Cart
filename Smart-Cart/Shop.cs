using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Smart_Cart
{

    public interface IShop
    {
        public void DisplayProducts(ShoppingCart cart){}
    }

    public class MenFashion : IShop
    {
        public List<Product> menProducts = new List<Product>
        {
            new Product { Name = "Calvin Klein Sports T-Shirt", Price = 50.99, Category = ProductCategory.MenClothes },
            new Product { Name = "Calvin Klein Watch", Price = 114.99, Category = ProductCategory.MenClothes },
            new Product { Name = "Levi's Jeans", Price = 59.99, Category = ProductCategory.MenClothes },
            new Product { Name = "ADIDAS Icons Q4 Hoodie", Price = 104.13, Category = ProductCategory.MenClothes },
        };

        public void DisplayProducts(ShoppingCart cart)
        {
            Console.WriteLine("Men's Fashion Products:");
            int counter = 1;
            foreach (var product in menProducts)
            {
                Console.WriteLine($"[{counter}]:{product.Name} - ${product.Price}");
                counter++;
            }

            Console.Write("Select a product to add to your cart: ");
            //string productNumber = Console.ReadLine();
            while (true)
            {
                Console.Write("Select a product to add to your cart: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userChoice);
                if (isNumber && userChoice > 0 && userChoice <= menProducts.Count)
                {
                    var selectedProduct = menProducts[userChoice - 1];
                    Console.WriteLine("===================================");
                    cart.AddCart(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to your cart");
                    Console.WriteLine("===================================\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        }
    }

    public class WomenFashion : IShop
    {
        public List<Product> womenProducts = new List<Product>
        {
            new Product { Name = "ALDO Heeled Pumps", Price = 50.90, Category = ProductCategory.WomenClothes },
            new Product { Name = "GUESS Mini Watch", Price = 29.17, Category = ProductCategory.WomenClothes },
            new Product { Name = "MANGO Dress", Price = 101.0, Category = ProductCategory.WomenClothes },
            new Product { Name = "Lacoste Women's Handbag", Price = 70.79, Category = ProductCategory.WomenClothes },
        };

        public void DisplayProducts(ShoppingCart cart)
        {
            Console.WriteLine("Women's Fashion Products:");
            int counter = 1;
            foreach (var product in womenProducts)
            {
                Console.WriteLine($"[{counter}]:{product.Name} - ${product.Price}");
                counter++;
            }
            while (true)
            {
                Console.Write("Select a product to add to your cart: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userChoice);
                if (isNumber && userChoice > 0 && userChoice <= womenProducts.Count)
                {
                    var selectedProduct = womenProducts[userChoice - 1];
                    Console.WriteLine("===================================");
                    cart.AddCart(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to your cart");
                    Console.WriteLine("===================================\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        }
    }

    public class KidsFashion : IShop
    {
        public List<Product> kidsProducts = new List<Product>
        {
            new Product { Name = "Moon Baby Car seat", Price = 275.90, Category = ProductCategory.Kids },
            new Product { Name = "Kids Backpack", Price = 29.17, Category = ProductCategory.Kids },
            new Product { Name = "Young Boy Overcoat", Price = 20.10, Category = ProductCategory.Kids },
            new Product { Name = "Floral Pattern Pajamas", Price = 16.79, Category = ProductCategory.Kids },
        };

        public void DisplayProducts(ShoppingCart cart)
        {
            Console.WriteLine("Kids Fashion Products:");
            int counter = 1;
            foreach (var product in kidsProducts)
            {
                Console.WriteLine($"[{counter}]:{product.Name} - ${product.Price}");
                counter++;
            }

            Console.Write("Select a product to add to your cart: ");
            while (true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out int userChoice);
                if (isNumber && userChoice > 0 && userChoice <= kidsProducts.Count)
                {
                    var selectedProduct = kidsProducts[userChoice - 1];
                    Console.WriteLine("===================================");
                    cart.AddCart(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to your cart");
                    Console.WriteLine("===================================\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        
        }
    }

    public class Home : IShop
    {
        public List<Product> homeProducts = new List<Product>
        {
            new Product { Name = "Kottend Ball", Price = 9.44, Category = ProductCategory.Home },
            new Product { Name = "Chair Covers", Price = 6.24, Category = ProductCategory.Home },
            new Product { Name = "Flower Print Oven Glove", Price = 1.99, Category = ProductCategory.Home },
            new Product { Name = "Plastic Storage Container", Price = 2.66, Category = ProductCategory.Home },
        };

        public void DisplayProducts(ShoppingCart cart)
        {
            Console.WriteLine("Home Products:");
            int counter = 1;
            foreach (var product in homeProducts)
            {
                Console.WriteLine($"[{counter}]:{product.Name} - ${product.Price}");
                counter++;
            }

            Console.Write("Select a product to add to your cart: ");
            while (true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out int userChoice);
                if (isNumber && userChoice > 0 && userChoice <= homeProducts.Count)
                {
                    var selectedProduct = homeProducts[userChoice - 1];
                    Console.WriteLine("===================================");
                    cart.AddCart(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to your cart");
                    Console.WriteLine("===================================\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
          
        }
    }
}
