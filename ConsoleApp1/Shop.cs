using System;
using System.Collections.Generic;
using System.IO;
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

                else if (choice == "4")
                {
                    Save("Player", "Store" );
                }

                else if (choice == "5")
                {
                    Load("Player", "Store");
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
            for (int i = 0; i < PlayerInventory.Length; i++)
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

                for (int i = 0; i < PlayerInventory.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + PlayerInventory[i].GetName() + " " + PlayerInventory[i].GetCost() + " Zbucks");
                }
                choice = Console.ReadLine();

                for (int i = 0; i < PlayerInventory.Length; i++)
                {
                    if (Convert.ToInt32(choice) == (i + 1))
                    {
                        Console.WriteLine("You sold " + PlayerInventory[i].GetName() + " " + PlayerInventory[i].GetCost() + " Zbucks");
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

            while (choice != "0")
            {
                Console.WriteLine("What are you buying today?");
                Console.WriteLine("0: Exit");

                for (int i = 0; i < StoreInventory.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + StoreInventory[i].GetName() + " " + StoreInventory[i].GetCost() + " Zbucks");
                }
                choice = Console.ReadLine();

                for (int i = 0; i < StoreInventory.Length; i++)
                {
                    if (Convert.ToInt32(choice) == (i + 1))
                    {
                        if (zbucks < StoreInventory[i].GetCost())
                        {
                            Console.WriteLine("You don't have enough.");
                        }
                        else
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
        }

        public void SecretMenu()
        {
            //The secret menu activated by EXEC_DIR

            //This is a sub for what I was trying to do before
            string choice = "";

            while(choice != "0")
            {
                Console.WriteLine("Welcome to the dev menu.");
                Console.WriteLine("What item would you like to create?");
                Console.WriteLine("0: Exit");

                for(int i = 0; i < ManagerInventory.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + ManagerInventory[i].GetName());
                }
                choice = Console.ReadLine();

                for (int i = 0; i < ManagerInventory.Length; i++)
                {
                    if (Convert.ToInt32(choice) == (i + 1))
                    {
                        Console.WriteLine("You created " + ManagerInventory[i].GetName() + " and added it to the shop");
                        shopInventory.Add(StoreInventory, ManagerInventory[i]);
                        StoreInventory = shopInventory.Get_itemList;                      
                        manager.Remove(ManagerInventory, i);
                        ManagerInventory = manager.GetmanagerInv;
                    }
                }
            }
            








            //This is what I was originally trying to do but could finish due to a small error
           /* string choice = "";

            Console.WriteLine("Item Maker Activated!");
            Console.WriteLine("\n");
            Console.WriteLine("would you like to create a weapon? y/n");

            choice = Console.ReadLine();

            if (choice == "y")
            {
                string name = "";
                string disc = "";
                int damage;
                int buff;
                int protection;
                int support;
                int cost;

                
                Console.WriteLine("Give your weapon name");
                name = Console.ReadLine();
                Console.WriteLine("How much damage do you want it to do?");
                choice = Console.ReadLine();
                damage = Convert.ToInt32(choice);
                Console.WriteLine("What will be its protection level?");
                choice = Console.ReadLine();
                protection = Convert.ToInt32(choice);
                Console.WriteLine("What will be its buff level?");
                choice = Console.ReadLine();
                buff = Convert.ToInt32(choice);
                Console.WriteLine("what will be its support level");
                choice = Console.ReadLine();
                support = Convert.ToInt32(choice);
                Console.WriteLine("How much do you want it to cost?");
                choice = Console.ReadLine();
                cost = Convert.ToInt32(choice);
                Console.WriteLine("Give it a description.");
                disc = Console.ReadLine();
                shopInventory.Add(new Weapons(name, damage, protection, buff, support, cost, disc));
                Console.WriteLine("Weapon Created. Dev Tool Closing");

            }
            else if (choice == "n")

            {
                return;
            }*/
            





        }

        public void Save( string path,  string path2)
        {                                                  //Might be buggy
            //Creates file for path
            StreamWriter writer = File.CreateText(path);           
            writer.WriteLine(PlayerInventory.Length);
            //Players funds
            writer.WriteLine(PlayerFuns);
            //Saves the Player Inventory
            foreach (Item a in PlayerInventory)
            {
                a.Save(writer);
            }

            writer.Close();

            //Creates file for  path2
            StreamWriter writer2 = File.CreateText(path2);           
            writer2.WriteLine(StoreInventory.Length);
            //Shops funds
            writer2.WriteLine(StoreFuns);
            //Saves the Shop Inventory
            foreach (Item b in StoreInventory)
            {
                b.Save(writer2);
            }
          
            writer2.Close();

            Console.WriteLine("Everything is saved");
        }
        public void Load(string path, string path2)
        {                                                 //Might be buggy
            
            int newArray = 0;

           
            if (File.Exists(path) && File.Exists(path2))
            {
                //Creates file for path
                StreamReader reader = File.OpenText(path);
                newArray = Convert.ToInt32(reader.ReadLine());             
                Item[] newArray2 = new Item[newArray];
                for (int i = 0; i < newArray2.Length - 1; i++)
                {
                    newArray2[i] = PlayerInventory[i];
                    newArray2[newArray - 1] = new Weapons("Fist", 1, 1, 1, 1, 0, "Real men will use nothing but bare hands!");
                }
                //Player funds
                PlayerFuns = Convert.ToInt32(reader.ReadLine());
                //Puts items to PlayerInventory
                foreach (Item a in newArray2)
                {
                    a.Load(reader);
                }
                
                PlayerInventory = newArray2;
                reader.Close();
                
                //Creates file for path2
                StreamReader reader2 = File.OpenText(path2);
                newArray = Convert.ToInt32(reader2.ReadLine());               
                Item[] newArray3 = new Item[newArray];
                for (int i = 0; i < newArray3.Length - 1; i++)
                {
                    newArray3[i] = StoreInventory[i];
                    newArray3[newArray - 1] = new Weapons("Stone Sword", 10, 5, 0, 0, 20, "A sword made out of rock. Enjoy it while it last");
                }
                
                StoreInventory = newArray3;
                //Stores funds
                StoreFuns = Convert.ToInt32(reader2.ReadLine());
                //Puts items in Store array
                foreach (Item b in StoreInventory)
                {
                    if (b is Item)
                    {
                        b.Load(reader2);
                    }
                }
                
                StoreInventory = newArray3;
                reader2.Close();
            }
            else
            {
                Console.WriteLine("Zero files.");

                
            }
        }








    }
}
