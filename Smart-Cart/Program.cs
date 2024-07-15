namespace Smart_Cart
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            var KidsFashion = new KidsFashion();
            var WomenFashion = new WomenFashion();
            var MenFashion = new MenFashion();
            var Home = new Home();
            var RandomProducts = new ProductGenerator();


            bool startShooping = true;
            while (startShooping)
            {
                Console.WriteLine("============== \tOFFER!\t ==============");
                Console.WriteLine("========= OFF 15% On Oreder +100$  =========\n");

                Console.WriteLine("Press [W] To Shop at Women Fashion");
                Console.WriteLine("Press [M] To Shop at Men Fashion");
                Console.WriteLine("Press [K] To Shop at Kids Fashion");
                Console.WriteLine("Press [H] To Shop at Home");
                Console.WriteLine("Press [R] Random Products");
                Console.WriteLine("Press [D] To Delete Itmes Cart");
                Console.WriteLine("Press [V] To View Cart");
                Console.WriteLine("Press [C] To Calculate Total Cost");
                Console.WriteLine("Press [Q] Quit");

                Console.Write("Start Shooping: ");
                String userOption = Console.ReadLine().ToUpper();

                switch (userOption) {
                    case "W":
                        WomenFashion.DisplayProducts(cart);
                        ProductGenerator.DisplayRandomProducts(cart, RandomProducts);
                        break;
                    case "M" :
                        MenFashion.DisplayProducts(cart);
                        ProductGenerator.DisplayRandomProducts(cart, RandomProducts);
                        break;
                    case "K":
                        KidsFashion.DisplayProducts(cart);
                        ProductGenerator.DisplayRandomProducts(cart, RandomProducts);
                        break;
                    case "H" :
                        Home.DisplayProducts(cart);
                        ProductGenerator.DisplayRandomProducts(cart, RandomProducts);
                        break;
                    case "R":
                        ProductGenerator.DisplayRandomProducts(cart, RandomProducts);
                        break;
                    case "D":
                        cart.ViewCart();
                        Console.Write("Select a product number to remove from your cart: ");
                        bool isNumber = int.TryParse(Console.ReadLine(), out int userChoice);
                        cart.RemoveCart(userChoice);
                        break;
                    case "V":
                        cart.ViewCart();
                        break;
                    case "C":
                        cart.TotalCost();
                        break;
                    case "Q":
                        Console.WriteLine("Finsh Shooping, See You Soon :)");
                        startShooping = false;
                        break;
                    default: 
                        Console.WriteLine("Invalid choice, Please try again");
                        break;
                }
            }
        }
    }
}
