using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Manager
    {
        private Item[] managerInv = new Item[6];

        public Manager()
        {
            //The Managers inventory

            managerInv[0] = new Weapons("Blood stick", 0, 15, 6, 7, 60, "Kill things with blood.");
            managerInv[1] = new Armor("Emerald Armor", 0, 25, 10, 8, 75, "Green is good.");
            managerInv[2] = new Armor("Steel Armor", 0, 40, 23, 18, 25, "Only good for a time.");
            managerInv[3] = new Potions("Invisable potion", 0, 45, 23, 16, 76, "Hope you like ghosts.");
            managerInv[4] = new Potions("Healing potion", 0, 60, 29, 25, 45, "The ultimate potions.");
            managerInv[5] = new Pets("Ben Drowned", 1234, 657, 246, 128, 125, "Creepy statue that follows you around.");




        }

        public Item[] GetmanagerInv
        {
            set
            {
                managerInv = value;
            }
            get
            {
                return managerInv;
            }
        }

        public Item[] Add(Item value)
        {
            Item[] oldlist = new Item[managerInv.Length + 1];

            for (int i = 0; i < managerInv.Length; i++)
            {
                oldlist[i] = managerInv[i];
            }

            oldlist[oldlist.Length - 1] = value;

            managerInv = oldlist;

            return managerInv;
        }

        public Item[] Remove(Item[] managerInventory, int index)
        {
            Item[] newlist = new Item[managerInv.Length - 1];

            int a = 0;

            for (int i = 0; i < managerInv.Length; i++)
            {
                if (i != index)
                {
                    newlist[a] = managerInv[i];
                    a++;
                }
            }

            managerInv = newlist;

            return managerInv;
        }


    }
}

