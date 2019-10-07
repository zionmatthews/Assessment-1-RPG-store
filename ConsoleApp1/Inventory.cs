using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Inventory
    {
        private Item[] _itemList = new Item[1];

        public Inventory()
        {
            //Character Inventory array
            _itemList[0] = new Weapons("Fist", 1, 1, 1, 1, "Real men will use nothing but bare hands!");
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
