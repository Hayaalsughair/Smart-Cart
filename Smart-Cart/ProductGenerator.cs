using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        public static readonly Random random = new Random();

        public Product GenerateProduct()
        {
            Dictionary<string, ProductCategory> randomProducts = new Dictionary<string, ProductCategory>
            {
                { "PUMA Sweatpants", ProductCategory.MenClothes},
                { "Ray-Ban Sunglasses", ProductCategory.MenClothes },
                { "MANGO Dallas Earrings", ProductCategory.WomenClothes },
                { "TOMMY Sweatshirt", ProductCategory.WomenClothes },
                { "Kids Prints Lunch Box", ProductCategory.Kids },
                { "Coupon Zone", ProductCategory.Kids},
                { "Candle Holder 5 Sticks", ProductCategory.Home },
                { "Flower Vase", ProductCategory.Home }
            };

            var randomProduct = random.Next(randomProducts.Count);
            var selectedProduct = randomProducts.ElementAt(randomProduct);

            double randomPrice = Math.Round(random.NextDouble() * 100, 2);

            return new Product
            {
                Name = selectedProduct.Key,
                Price = randomPrice,
                Category = selectedProduct.Value
            };
        }

        public List<Product> GenerateMultipleProducts(int count)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                products.Add(GenerateProduct());
            }
            return products;
        }

        public static void DisplayRandomProducts(ShoppingCart cart, ProductGenerator productGenerator)
        {
            List<Product> randomProducts = productGenerator.GenerateMultipleProducts(5);
            Console.WriteLine("Products you may like:");
            for (int i = 0; i < randomProducts.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {randomProducts[i].Name} - ${randomProducts[i].Price} - Category: {randomProducts[i].Category}");
            }
            Console.WriteLine("[X] Exit");

            while (true)
            {
                Console.Write("Select a product to add to your cart or press 'X' to exit: ");
                string userInput = Console.ReadLine().ToUpper();

                if (userInput == "X")
                {
                    Console.WriteLine("Exiting from suggested products.");
                    break;
                }
                else if (int.TryParse(userInput, out int userChoice) && userChoice > 0 && userChoice <= randomProducts.Count)
                {
                    var selectedProduct = randomProducts[userChoice - 1];
                    Console.WriteLine("===================================");
                    cart.AddCart(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to your cart");
                    Console.WriteLine("===================================\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5 or 'X' to exit.");
                }
            }
        }
    }
}
