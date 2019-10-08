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

        public string GetName()
        {
            return _name;
        }

        public int GetSupport()
        {
            return _support;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetProtection()
        {
            return _protection;
        }

        public int GetDamage()
        {
            return _damage;
        }

        public int GetBuff()
        {
            return _buff;
        }
    }
}
