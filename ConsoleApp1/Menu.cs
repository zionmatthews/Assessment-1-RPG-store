using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Menu
    {
        
        string choice = "";

        Item[] storeInventory;
        Item[] playerInventory;
        Item[] storeFunds;
        Item[] playerFunds;






        public void Shop()
        {


            string choice = "";

            while (choice != "8")
            {
                //Store Menu
                Console.WriteLine("Welcome to my little shop of terror!");
                Console.WriteLine("");
                Console.WriteLine("Would you like to buy or sell anything? Prehaps, check your inventory?");
                Console.WriteLine("1: Check Inventory");
                Console.WriteLine("2: Sell Items");
                Console.WriteLine("3: Buy Items");
                Console.WriteLine("4: Save and load");
                Console.WriteLine("5: Exit");
                

                choice = Console.ReadLine();

                //Choice imputs

                if (choice == "1")
                {
                    Inventory();
                }

                else if (choice == "2")
                {
                    SellItems();
                }

                else if(choice == "3")
                {
                    BuyItems();
                }

               
            }



        }

        static void Inventory()
        {
            //Checks the Inventory
        }

        static void SellItems()
        {
            //Sells any item in the Player Inventory
        }

        static void BuyItems()
        {
            //Buys items in the shop inventory
        }

        







    }
}
