using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Inventory
    {
        private Item[] _playerList = new Item[1];

        public Inventory()
        {
            //Character Inventory array
            _playerList[0] = new Weapons("Fist", 1, 1, 1, 1, "Real men will use nothing but bare hands!");
        }

        public Item[] Get_playerList
        {
            set
            {
                _playerList = value;
            }
            get
            {
                return _playerList;
            }
        }

        public Item[] Add(Item value)
        {
            Item[] oldlist = new Item[_playerList.Length + 1];

            for (int i = 0; i < _playerList.Length; i++)
            {
                oldlist[i] = _playerList[i];
            }

            oldlist[oldlist.Length - 1] = value;

            _playerList = oldlist;

            return _playerList;
        }

        public Item[] Remove(int index)
        {
            Item[] newlist = new Item[_playerList.Length - 1];

            int a = 0;

            for (int i = 0; i < _playerList.Length; i++)
            {
                if (i != index)
                {
                    newlist[a] = _playerList[i];
                    a++;
                }
            }

            _playerList = newlist;

            return _playerList;
        }
    }
}
