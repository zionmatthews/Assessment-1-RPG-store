using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Shop
    {

        


        static protected Item[] PlayerInventory;
        static protected Item[] StoreInventory;
        static protected Item[] ManagerInventory;

        Inventory inventory = new Inventory();
        ShopInventory shopInventory = new ShopInventory();
        Manager manager = new Manager();


        public Shop()
        {
            StoreInventory = shopInventory.Get_itemList;
            PlayerInventory = inventory.Get_playerList;
            ManagerInventory = manager.GetmanagerInv;

        }





        public void Menu()
        {


            string choice = "";

            while (choice != "5")
            {
                //Store Menu
                Console.WriteLine("This is my little shop of terror!");
                Console.WriteLine("");
                Console.WriteLine("Would you like to buy or sell anything? Prehaps, check your inventory?");
                Console.WriteLine("1: Check Inventory");
                Console.WriteLine("2: Sell Items");
                Console.WriteLine("3: Buy Items");
                Console.WriteLine("4: Save");
                Console.WriteLine("5: Load");
                Console.WriteLine("6: Exit");


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

                else if (choice == "3")
                {
                    BuyItems();
                }

                else if (choice == "Lanch_EXEC")
                {
                    SecretMenu();
                }


            }



        }

        static void Inventory()
        {
            //Checks the player Inventory
            Console.WriteLine("\n Here is your inventory.");
            for (int i = 0; i < PlayerInventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + PlayerInventory[i].GetName());
            }
        }

        static void SellItems()
        {
            //Sells any item in the Player Inventory
        }

        static void BuyItems()
        {
            //Buys items in the shop inventory
        }

        static void SecretMenu()
        {
            //The secret menu activated by Lanch_EXEC
            Console.WriteLine("You just unlocked the managers inventory!!");
        }









    }
}
