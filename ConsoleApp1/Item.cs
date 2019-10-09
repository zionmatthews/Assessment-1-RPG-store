using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Item
    {
        protected int _damage;
        protected int _buff;
        protected string _name;
        protected int _support;
        protected string _description;
        protected int _protection;
        protected int _cost;


        public int GetDamage()
        {
            return _damage;
        }

        public int GetBuff()
        {
            return _buff;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetSupport()
        {
            return _support;
        }

        public string Getdescription()
        {
            return _description;
        }

        public int GetProtection()
        {
            return _protection;
        }

        public int GetCost()
        {
            return _cost;
        }



    }

}
