using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Program : Menu
    {

        static void Main(string[] args)
        {
            string name = "";
            string choice = "";




            Console.WriteLine("Please enter your name :");
            name = Console.ReadLine();

            Console.WriteLine("Welcome " + name);




            Menu menu = new Menu();
            menu.Shop();





        }




    }
}