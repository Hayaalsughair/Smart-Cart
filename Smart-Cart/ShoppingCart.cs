using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
       
        public List<Product> items = new List<Product>();
        
        public bool AddCart(Product item)
        {
            items.Add(item);
            Console.WriteLine("Add to cart successfully!");
            return true;
        }
        public bool RemoveCart(int userChoice)
        {
            if(items.Count == 0)
            {
                Console.WriteLine("Empty Cart!");
                return false;
            }
            if (userChoice > 0 && userChoice <= items.Count)
            {
                var removedProduct = items[userChoice - 1];
                items.RemoveAt(userChoice - 1);
                Console.WriteLine($"[{removedProduct.Name}] removed from your cart.\n");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            ViewCart();
            return false;

        }
        public void ViewCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("\nEmpty Cart, Start Shooping by=>\n");
            }
            else {
                Console.WriteLine($"=========Cart Items ({items.Count}) =========");
                int counter = 1; 
                foreach (var item in items)
                {
                    Console.WriteLine($"[{counter}]:{item.Name}-{item.Category} {item.Price}$");
                    counter++;
                }
               // Console.WriteLine("=============================\n");
                //TotalCost();
            }

        }
        public double TotalCost()
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Price;
            }

            Console.WriteLine("==========================");
            Console.WriteLine($"\tTotal Cost: {totalCost}$");
            Console.WriteLine("==========================");

            double finalCost = Discount(totalCost);
            return finalCost;
        }
        public double Discount(double totalCost)
        {
            if (totalCost >= 100)
            {
                double discountOffer = totalCost * 0.15;
                double newCost = totalCost - discountOffer;

                Console.WriteLine($"\tDiscount Applied: {discountOffer}$");
                Console.WriteLine($"\tNew Total Cost: {newCost}$");
                Console.WriteLine("==========================");

                return newCost;
            }
            else
            {
                Console.WriteLine("==========================");
                Console.WriteLine("\tNo discount applied.");
                Console.WriteLine("==========================");
            }

            return totalCost;
        }
    }   
}
