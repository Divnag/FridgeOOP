using System;
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
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Hello welcome to fridge app.");
                Console.WriteLine("what would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change the lightbulb,Type 2");
                Console.WriteLine("To clean ,type 3");
                Console.WriteLine("To take food,type 4");
                Console.WriteLine("To check food supplies,type 5");
                Console.WriteLine("To see all fridge details,type 6");
                Console.WriteLine("To restart,type 7");
                Console.WriteLine("To quit,type 8");
                
                userChoice = int.Parse(Console.ReadLine());
                
                switch(userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;
                    case 3:
                        Console.WriteLine( userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("Enter the amount of food removed");
                        int removedFood;
                        removedFood = int.Parse(Console.ReadLine());

                        userFridge.RemoveFood(removedFood);
                        Console.WriteLine("Remaing food"+userFridge.FoodAmount);
                        break;
                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine(userFridge.Clean());
                        Console.WriteLine("Type of dispenser: " + userFridge.DispenserType);
                        Console.WriteLine("Remaing food:  " + userFridge.FoodAmount);
                        Console.WriteLine("Bulb:  " + userFridge.BulbWork);
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                            
                    default:
                        Console.WriteLine("please enter valid number");
                        break;


                }
            } while((userChoice != 8)||(userChoice==7));
        }
    }


}
