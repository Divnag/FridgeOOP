﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create interactive console windows
            //prompt user to choose what to do with the fridge
            //call methods on fridge object to do what the user wants
            int userChoice;
            do
            {
                Console.WriteLine("Hello welcome to fridge app.");
                Console.WriteLine("what would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change the lightbulb,Type 2");
                Console.WriteLine("To clen ,type 3");
                Console.WriteLine("To take food,type 4");
                Console.WriteLine("To check food supplies,type 5");
                Console.WriteLine("To see all fridge details,type 6");
                Console.WriteLine("To restart,type 7");
                Console.WriteLine("To quit,type 8");

                userChoice = int.Parse(Console.ReadLine());
            } while (userChoice != 8);
        }




    }


}
