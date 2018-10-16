using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
    class Program
    {
        class Patron
        {
            public Patron(string name)
            {
                Name = name;
            }

            public string Name { get; }
        }

        class FoodItem { public int DishID; }

        interface KitchenSection
        {
            FoodItem PrepDish(int DishID);
        }

        class Order
        {
            public FoodItem Appetizer { get; set; }
            public FoodItem Entree { get; set; }
            public FoodItem Drink { get; set; }
        }

        class ColdPrep : KitchenSection
        {
            public FoodItem PrepDish(int dishID)
            {
                return new FoodItem()
                {
                    DishID = dishID
                };
            }
        }
        class HotPrep : KitchenSection
        {
            public FoodItem PrepDish(int dishID)
            {
                return new FoodItem()
                {
                    DishID = dishID
                };
            }
        }
        class Bar : KitchenSection
        {
            public FoodItem PrepDish(int dishID)
            {
                return new FoodItem()
                {
                    DishID = dishID
                };
            }
        }
        class Server
        {
            private ColdPrep _coldPrep = new ColdPrep();
            private Bar _bar = new Bar();
            private HotPrep _hotPrep = new HotPrep();

            public Order PlaceOrder(Patron patron,
                                    int coldAppID,
                                    int hotEntreeID,
                                    int drinkID)
            {
                Console.WriteLine("{0} places order for cold app #"
                                    + coldAppID.ToString()
                                    + ", hot entree # " + hotEntreeID.ToString()
                                    + ", and drink #" + drinkID.ToString() + ".");

                Order order = new Order
                {
                    Appetizer = _coldPrep.PrepDish(coldAppID),
                    Entree = _hotPrep.PrepDish(hotEntreeID),
                    Drink = _bar.PrepDish(drinkID)
                };

                return order;
            }
        }

        static void Main(string[] args)
        {
            Server server = new Server();

            Console.WriteLine("Hello! i'll be your server today. what is your name?");
            var name = Console.ReadLine();

            Patron patron = new Patron(name);

            Console.WriteLine("Hello " + patron.Name
                              + ". What appetizer would you like? (1-15):");
            var appID = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a good one. What entree would you like? (1-20):");
            var entreeID = int.Parse(Console.ReadLine());

            Console.WriteLine("A great choice! Finally, what drink would you like? (1-60):");
            var drinkID = int.Parse(Console.ReadLine());

            Console.WriteLine("i'll get that order in right away.");

            //Here's what the Facade simplifies
            server.PlaceOrder(patron, appID, entreeID, drinkID);

            Console.ReadKey();
        }

    }
}
