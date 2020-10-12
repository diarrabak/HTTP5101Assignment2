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
        /// <example> GET api/J1/Menu/4/4/4/4-->returns 0 </example>
        /// <example> GET api/J1/Menu/1/2/3/4-->returns 691  </example>
        /// </summary>
        /// <param name="burger">First parameter representing the burger</param>
        /// <param name="drink">Second parameter representing the drink</param>
        /// <param name="side">Third parameter representing the burgerside menu </param>
        /// <param name="dessert">Fourth parameter representing the dessert</param>
        /// <returns> Your total calorie count is 0.</returns>



        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            // Parameter for the quantity of calorie in each type of food
            int burgerCalorie, drinkCalorie, sideCalorie, dessertCalorie, totalCalorie;  

            //There are 4 types of burger with different calorie content

            if (burger == 1)           //Cheese burger chosen
            {
                burgerCalorie = 461;      
            }else if (burger == 2)     //Fish burger chosen
            {
                burgerCalorie = 431;
            } else if (burger == 3)    //Veggie burger chosen
            {
                burgerCalorie = 420;       
            } else                     // No burger
            {
                burgerCalorie = 0;
            }
          
            /////There are 4 types of drink with different calorie content

            if (drink == 1)           //Soft drink
            {
                drinkCalorie = 130;
            }
            else if (drink == 2)      //Orange juice
            {
                drinkCalorie = 160;
            }
            else if (drink == 3)      //Milk
            {
                drinkCalorie = 118;
            }
            else                       //No drink
            {
                drinkCalorie = 0;
            }

          
            /////There are 4 types of side order with different calorie content

            if (side == 1)             //Fries
            {
                sideCalorie = 100;
            }
            else if (side == 2)        //Baked potato
            {
                sideCalorie = 57;
            }
            else if (side == 3)        //Chef salad
            {
                sideCalorie = 70;
            }
            else
            {
                sideCalorie = 0;          //No side order
            }

            
            /////There are 4 types of dessert with different calorie content

            if (dessert == 1)          //Apple pie
            {
                dessertCalorie = 167;
            }
            else if (dessert == 2)     //Sundae
            {
                dessertCalorie = 266;
            }
            else if (dessert == 3)     //Fruit cup
            {
                dessertCalorie = 75;
            }
            else                       //No dessert
            {
                dessertCalorie = 0;
            }

            //Total quantity of calorie contained in the 4 choices
            totalCalorie = burgerCalorie + drinkCalorie + sideCalorie + dessertCalorie;

            //Message giving the calory content information
            return "Your total calorie count is " + totalCalorie;          
        }
    }
}


