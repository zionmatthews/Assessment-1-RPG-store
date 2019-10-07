using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class ShopInventory
    {
        private Item[] _itemList = new Item[24];

        public ShopInventory()
        {
            //Shop Inventory Array

            //Item   Item Name    D   P   B   S    Description
            _itemList[0] = new Weapons("Stone Sword", 10, 5, 0, 0, "A sword made out of rock. Enjoy it while it last");
            _itemList[1] = new Weapons("Iron Axe", 20, 3, 0, 0, "Does more damage then a rock sword.");
            _itemList[2] = new Weapons("CrossBow", 35, 0, 0, 0, "Be like that man on walking dead.");
            _itemList[3] = new Weapons("Smg", 40, 15, 0, 0, "Don't like melee weapons? Use a gun");
            _itemList[4] = new Weapons("ButterFly Knife", 70, 30, 0, 0, "The ideal weapon for the ideal man.");
            _itemList[5] = new Weapons("Infinity Sword", 800, 800, 500, 1000, "A weapon made for a god");

            _itemList[6] = new Armor("Chain Armor", 0, 15, 6, 7, "Good for training.");
            _itemList[7] = new Armor("Iron Armor", 0, 25, 10, 8, "Good for fighting basic enemies");
            _itemList[8] = new Armor("Redstone Armor", 0, 40, 23, 18, "Awesome for fighting Monsters.");
            _itemList[9] = new Armor("Gold Armor", 0, 45, 23, 16, "Hope you like butter.");
            _itemList[10] = new Armor("Diamond Armor", 0, 60, 29, 25, "The ultimate armor for a hero");
            _itemList[11] = new Armor("Zion's Armor", 1234, 657, 246, 128, "My Armor that a mearl mortal cannot handle.");

            _itemList[12] = new Potions("Speed Potion", 0, 0, 15, 15, "Good for fighting dragons");
            _itemList[13] = new Potions("Fire Potion", 0, 0, 20, 20, "Very good for fighting dragons");
            _itemList[14] = new Potions("Strength potion", 5, 0, 25, 25, "Useful in fights or moving things.");
            _itemList[15] = new Potions("Leaping Potion", 0, 0, 25, 30, "An awesome potion to have and very useful");
            _itemList[16] = new Potions("Hardening Potion", 0, 0, 30, 31, "Be like a rock.");
            _itemList[17] = new Potions("Thanos snap potion", 50000, 0, 1000, 1000, "Snap all your enemies away. One time use");

            _itemList[18] = new Pets("Dog", 10, 10, 10, 10, "Have fun with this loyal little guy.");
            _itemList[19] = new Pets("Iron Golem", 20, 15, 20, 20, "He lives to surve");
            _itemList[20] = new Pets("Hawk", 20, 20, 25, 25, "The feathery friend will guide and help you");
            _itemList[21] = new Pets("Fishstick", 0, 0, 0, 0, "Why, just why?");
            _itemList[22] = new Pets("Dragon", 35, 25, 30, 27, "You're a very lucky person to have found this guy when he was still in a egg.");
            _itemList[23] = new Pets("Cosmic GreatDane", 1000000000, 10000000, 100000000, 1000, "The perfect pet for the perfect being");


        }

        public Item[] Get_itemList
        {
            set
            {
                _itemList = value;
            }
            get
            {
                return _itemList;
            }
        }

        public Item[] Add(Item value)
        {
            Item[] oldlist = new Item[_itemList.Length + 1];

            for (int i = 0; i < _itemList.Length; i++)
            {
                oldlist[i] = _itemList[i];
            }

            oldlist[oldlist.Length - 1] = value;

            _itemList = oldlist;

            return _itemList;
        }

        public Item[] Remove(int index)
        {
            Item[] newlist = new Item[_itemList.Length - 1];

            int a = 0;

            for (int i = 0; i < _itemList.Length; i++)
            {
                if (i != index)
                {
                    newlist[a] = _itemList[i];
                    a++;
                }
            }

            _itemList = newlist;

            return _itemList;
        }
    }
}
