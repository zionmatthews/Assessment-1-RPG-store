using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Shop
    {

        string choice = "";


        static protected Item[] PlayerInventory;
        static protected Item[] StoreInventory;
        static protected Item[] ManagerInventory;
        static protected int PlayerFuns;
        static protected int StoreFuns;
        

        Inventory inventory = new Inventory();
        ShopInventory shopInventory = new ShopInventory();
        Manager manager = new Manager();


        public Shop()
        {
            StoreInventory = shopInventory.Get_itemList;
            PlayerInventory = inventory.Get_playerList;
            ManagerInventory = manager.GetmanagerInv;
            PlayerFuns = 500;
            StoreFuns = 1000;
            
        }

        public int GetFuns()
        {
            return PlayerFuns;
        }

        public int GetStoreFuns()
        {
            return StoreFuns;
        }





        public void Menu()
        {


            string choice = "";

            while (choice != "6")
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
                    CheckInventory();
                }

                else if (choice == "2")
                {
                    SellItems();
                }

                else if (choice == "3")
                {
                    BuyItems();
                }

                else if (choice == "EXEC_DIR")
                {
                    SecretMenu();
                }


            }



        }

        public void CheckInventory()
        {
            //Checks the player Inventory
            Console.WriteLine("\nHere is your inventory");
            Console.WriteLine("");
            for(int i = 0; i < PlayerInventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + PlayerInventory[i].GetName());
            }
            Console.WriteLine("Zbucks: " + PlayerFuns);

        }

        public void SellItems()
        {
            //Sells any item in the Player Inventory
            string choice = "";
            int zbucks = GetFuns();
            int Store = GetStoreFuns();

            while (choice != "0")
            {
                Console.WriteLine("What are you selling today");
                Console.WriteLine("0: Exit");

                for(int i = 0; i < PlayerInventory.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + PlayerInventory[i].GetName() +" " + PlayerInventory[i].GetCost() + " Zbucks");
                }
                choice = Console.ReadLine();

                for(int i = 0; i < PlayerInventory.Length; i++)
                {
                    if(Convert.ToInt32(choice) == (i + 1))
                    {
                        Console.WriteLine("You sold " + PlayerInventory[i].GetName() + " " + PlayerInventory[i].GetCost() + " Zbuckz");
                        shopInventory.Add(StoreInventory, PlayerInventory[i]);
                        StoreInventory = shopInventory.Get_itemList;
                        PlayerFuns = (zbucks + PlayerInventory[i].GetCost());
                        StoreFuns = (Store - PlayerInventory[i].GetCost());
                        inventory.Remove(PlayerInventory, i);
                        PlayerInventory = inventory.Get_playerList;

                        choice = "0";
                    }
                }

            } 
        }

        public void BuyItems()
        {
            //Buys items in the shop inventory
            string choice = "";
            int zbucks = GetFuns();
            int Store = GetStoreFuns();

            while(choice != "0")
            {
                Console.WriteLine("What are you buying today?");
                Console.WriteLine("0: Exit");

                for(int i = 0; i < StoreInventory.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + StoreInventory[i].GetName() + " " + StoreInventory[i].GetCost() + " Zbucks");
                }
                choice = Console.ReadLine();

                for(int i = 0; i < StoreInventory.Length; i++)
                {
                    if (Convert.ToInt32(choice) == (i + 1))
                    {
                        Console.WriteLine("You bought " + StoreInventory[i].GetName() + " " + StoreInventory[i].GetCost() + " Zbucks");
                        inventory.Add(PlayerInventory, StoreInventory[i]);
                        PlayerInventory = inventory.Get_playerList;
                        PlayerFuns = (zbucks - StoreInventory[i].GetCost());
                        StoreFuns = (Store + StoreInventory[i].GetCost());
                        shopInventory.Remove(StoreInventory, i);
                        StoreInventory = shopInventory.Get_itemList;

                        choice = "0";
                    }
                }
            }
        }

        public void SecretMenu()
        {
            //The secret menu activated by Lanch_EXEC
            string choice = "";

            while(choice != "0")
            {
                Console.WriteLine("You just unlocked the managers inventory!!");
                Console.WriteLine("What are you taking?");
                Console.WriteLine("0: Exit");

                for(int i = 0; i < ManagerInventory.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + ManagerInventory[i].GetName());
                }
                choice = Console.ReadLine();

                for(int i = 0; i < ManagerInventory.Length; i++)
                {
                    if(Convert.ToInt32(choice) == (i + 1))
                    {
                        Console.WriteLine("You Took " + ManagerInventory[i].GetName() + "from the manager");
                        inventory.Add(PlayerInventory, ManagerInventory[i]);
                        PlayerInventory = inventory.Get_playerList;
                        manager.Remove(ManagerInventory, i);
                        ManagerInventory = manager.GetmanagerInv;

                        choice = "0";
                    }
                }
            }




            
        }









    }
}
