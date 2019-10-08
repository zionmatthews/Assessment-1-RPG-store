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
            string choice = "";




            Console.WriteLine("Please enter your name :");
            name = Console.ReadLine();

            Console.WriteLine("Welcome " + name);




            Shop shop = new Shop();
            shop.Menu();





        }




    }
}