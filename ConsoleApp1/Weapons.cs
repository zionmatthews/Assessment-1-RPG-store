﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Weapons : Item
    {
        

        public int setDamage
        {
            set
            {
                _damage = value;
            }
            get
            {
                return _damage;
            }
        }

        public int setbuff
        {
            set
            {
                _buff = value;
            }
            get
            {
                return _buff;
            }
        }

        public int setprotection
        {
            set
            {
                _protection = value;
            }
            get
            {
                return _protection;
            }
        }

        public int setsupport
        {
            set
            {
                _support = value;
            }
            get
            {
                return _support;
            }
        }

        public int setcost
        {
            set
            {
                _cost = value;
            }
            get
            {
                return _cost;
            }
        }

        public Weapons(string newName, int newDamage, int newProtection, int newBuff, int newSupport, int newCost, string newDescription)
        {
            _name = newName;
            _damage = newDamage;
            _protection = newProtection;
            _buff = newBuff;
            _support = newSupport;
            _description = newDescription;
            _cost = newCost;


        }

    }
}
