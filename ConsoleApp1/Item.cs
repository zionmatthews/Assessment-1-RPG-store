using System;
using System.Collections.Generic;
using System.IO;
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
        public void Save(StreamWriter writer)
        {
            writer.WriteLine(GetName());
            writer.WriteLine(GetDamage());
            writer.WriteLine(GetProtection());
            writer.WriteLine(GetBuff());
            writer.WriteLine(GetSupport());
            writer.WriteLine(GetCost());
            writer.WriteLine(Getdescription());
            
        }
        public void Load(StreamReader reader)
        {
            //Loads the save state to place into passed in array
            _name = reader.ReadLine();
            _damage = Convert.ToInt32(reader.ReadLine());
            _protection = Convert.ToInt32(reader.ReadLine());
            _buff = Convert.ToInt32(reader.ReadLine());
            _support = Convert.ToInt32(reader.ReadLine());
            _cost = Convert.ToInt32(reader.ReadLine());
            _description = reader.ReadLine();
        }



    }

}
