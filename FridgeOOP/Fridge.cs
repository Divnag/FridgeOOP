using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
   public class Fridge
    {
        //fields 
        private bool isClean;
        private String dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
         }

        public String DispenserType
        {
            get { return this.dispenserType; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }
        public bool BulbWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }
        //Constructors

        public  Fridge()
        {
            this.dispenserType = "basic water dispenser";
        }

        public Fridge(String dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean,String dispenserType,int foodAmount,bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }

        //Methods()
         //i need a way to dispense water

        public void DispenseWater()
        {
            if(dispenserType=="basic water dispenser")
            {
                Console.WriteLine("Here is some water");
            }

            else if(dispenserType=="deluxe dispenser")
            {
                Console.WriteLine(  "enjoy your ice water");
            }
            else
            {
                Console.WriteLine("What's gonna come out? Its a surprize");
            }
        }

        public String ChangeBulbs()
        {
            if(bulbsWork==false)
            {
                bulbsWork = true;
                return "The bulbs have been changed";
            }

            else
            {
                return "The bulbs dont have to be changed";
            }
        }
        public void RemoveFood(int foodRemoved)
        {
            foodAmount -= foodRemoved;
            

        }

        public  string CheckSupplies()
        {
            if(foodAmount>=80)
            {
                return "fully stocked";

            }
            else if(foodAmount>40)
            {
                return "getting low";
            }
            else {
                return "time to grocery shop";
             }
        }
         
        public String Clean()
        {
            if(isClean==false)
            {
                isClean = true;
                return "Cleaned the fridge";
            }
            else
            {
                return "the fridge already clean";
            }

        }
    }
}
