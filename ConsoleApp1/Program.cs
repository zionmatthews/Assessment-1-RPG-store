using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Program : Shop
    {

        static void Main(string[] args)
        {
            string name = "";

            string filepath = "c:\\Assessment 1\\Player.txt";

            Shop shop = new Shop();
            shop.

            Load("Player", "Store");

            Console.WriteLine("Please enter your name :");
            name = Console.ReadLine();

            Console.WriteLine("Welcome " + name);




            Shop shopm = new Shop();
            shopm.Menu();

            



        }




    }
}
