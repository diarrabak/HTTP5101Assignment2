using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_B_Diarra.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// This method takes 4 integers repressenting 4 types of food and returns the amount of calories contained in them.
        /// <example> GET api/J1/Menu/4/4/4/4 </example>
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <returns> Your total calorie count is 0.</returns>



        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        // GET api/J1/Menu/4/4/4/4
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            int burgerCal, drinkCal, sideCal, dessertCal, calory;  // Quantity of calorie in each type of food

            // The switch is the best choice in this case but we didn't see it yet in class, so I go with if


            //There are 4 types of burger with different calorie content

            if (burger == 1)           //Cheese burger chosen
            {
                burgerCal = 461;      
            }else if (burger == 2)     //Fish burger chosen
            {
                burgerCal = 431;
            } else if (burger == 3)    //Veggie burger chosen
            {
                burgerCal = 420;       
            } else                     // No burger
            {
                burgerCal = 0;
            }
            //////////////////////////////////////////////
            /////There are 4 types of drink with different calorie content

            if (drink == 1)           //Soft drink
            {
                drinkCal = 130;
            }
            else if (drink == 2)      //Orange juice
            {
                drinkCal = 160;
            }
            else if (drink == 3)      //Milk
            {
                drinkCal = 118;
            }
            else                       //No drink
            {
                drinkCal = 0;
            }

            //////////////////////////////////////////////
            /////There are 4 types of side order with different calorie content

            if (side == 1)             //Fries
            {
                sideCal = 100;
            }
            else if (side == 2)        //Baked potato
            {
                sideCal = 57;
            }
            else if (side == 3)        //Chef salad
            {
                sideCal = 70;
            }
            else
            {
                sideCal = 0;          //No side order
            }

            ////////////////////////////////////////////////////
            /////There are 4 types of dessert with different calorie content

            if (dessert == 1)          //Apple pie
            {
                dessertCal = 167;
            }
            else if (dessert == 2)     //Sundae
            {
                dessertCal = 266;
            }
            else if (dessert == 3)     //Fruit cup
            {
                dessertCal = 75;
            }
            else                       //No dessert
            {
                dessertCal = 0;
            }

            calory = burgerCal + drinkCal + sideCal + dessertCal; //Total quantity of calorie contained in the 4  choices
            return "Your total calorie count is "+calory;          //Message giving the calory content information
        }
    }
}



/*
            switch (burger)
            {
                case 1:
                    burgerCal = 461;
                    break;
                case 2:
                    burgerCal = 431;
                    break;
                case 3:
                    burgerCal = 420;
                    break;
                default:
                    burgerCal = 0;
                    break;
            }

            switch (drink)
            {
                case 1:
                    drinkCal = 130;
                    break;
                case 2:
                    drinkCal = 160;
                    break;
                case 3:
                    drinkCal = 118;
                    break;
                default:
                    drinkCal = 0;
                    break;
            }

            switch (side)
            {
                case 1:
                    sideCal = 100;
                    break;
                case 2:
                    sideCal = 57;
                    break;
                case 3:
                    sideCal = 70;
                    break;
                default:
                    sideCal = 0;
                    break;
            }

            switch (dessert)
            {
                case 1:
                    dessertCal = 167;
                    break;
                case 2:
                    dessertCal = 266;
                    break;
                case 3:
                    dessertCal = 75;
                    break;
                default:
                    dessertCal = 0;
                    break;
            }*/