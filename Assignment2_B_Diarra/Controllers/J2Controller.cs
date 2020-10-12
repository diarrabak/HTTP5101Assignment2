using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_B_Diarra.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This method takes two integers representing the faces of two dice and returns the number of time the sum of the faces of the two dices gives 10. 
        /// <example> GET api/J2/DiceGame/6/8  -->returns 5</example>
        /// <example> GET api/J2/DiceGame/12/4 -->returns 4</example>
        /// <example> GET api/J2/DiceGame/4/4  -->returns 0</example>
        /// </summary>
        /// <param name="m">face number of the first die</param>
        /// <param name="n">face number of the second die</param>
        /// <returns>There are 5 total ways to get the sum 10. </returns>
        
        [Route("api/J2/DiceGame/{m}/{n}")]
        
        public string GetDiceGame(int m, int n)
        {
            //Variable taking the value to be met by the sum of m + n
            int GuestValue = 10;     
            //Variable counting the number 10 obtained
            int occurence = 0;

            //Loop on the two dice m and n
            for (int i = 1; i <= m; i++)      
            {
                for (int j = 1; j <= n; j++)
                {
                    //Check the sum is equal to 10
                    if ((i+j)== GuestValue)     
                    {
                        // Increment the number of occurence of 10
                        occurence += 1;        
                    }
                }
            }
            //Message indicating the number of ways we can get 10.
            return "There are " + occurence + " total ways to get the sum 10. "; 
        }
    }
}
