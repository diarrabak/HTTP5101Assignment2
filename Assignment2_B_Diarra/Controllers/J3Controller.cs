using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_B_Diarra.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This method takes a string containing many strings separated by a comma and returns the time required to type each of them in an integer array. 
        /// The string "halt" is the string which stops the calculation.
        /// <example> GET api/J3/requiredTime/a,dada,bob,abba,cell,www,halt -->returns [1 4 7 12 13 7]</example>
        /// <example> GET api/J3/requiredTime/java,csharp,http,halt,humber -->returns [6 16 7]</example>
        /// </summary>
        /// <param name="words_input"> string containing many comma-separated strings</param>
        /// <returns>[1 4 7 12 13 7] </returns>

        [Route("api/J3/requiredTime/{words_input}")]
        // GET api/J3/requiredTime/java,csharp,http,halt,humber

        public IEnumerable<int> GetTime(string words_input)
       {

            //retrieve the different strings inside the mehtod parameter and store them a string array
            string[] word_split = words_input.Split(',');   
            int time = 0;                                   //required time for single letter
            string words;
            int haltposition=0;

            // The variable containing the required time for each string
            int[] totalTime = new int[word_split.Length];   


            //Adapt the length of the time variable to the number of string before the stop string which is "halt"

            for (int ii = 0; ii < word_split.Length; ii++)
            {
                words = word_split[ii];

                if (words == "halt")
                {
                    haltposition = ii;       //New length of the strings to be considered
                    totalTime = new int[haltposition];     
                    break;
                   
                }
            }

            //Beginning of the time count for each word depending on characters position on the button and then in the word

            for (int i = 0; i < word_split.Length; i++)
            {
                words = word_split[i];   //Go through all the strings

                if (words == "halt")     // Stop condition
                {
                    break;
                }

                //Effect of the character position on the button on the time

                for (int j = 0; j < words.Length; j++)
                {
                    //First characters on buttons require 1 second
                    if (words[j] == 'a' || words[j] == 'd' || words[j] == 'g' || words[j] == 'j' || words[j] == 'm' || words[j] == 'p' || words[j] == 't' || words[j] == 'w')   
                    {
                        time = 1;
                    }
                    //Second characters on buttons require 2 seconds
                    else if (words[j] == 'b' || words[j] == 'e' || words[j] == 'h' || words[j] == 'k' || words[j] == 'n' || words[j] == 'q' || words[j] == 'u' || words[j] == 'x') 
                    {
                        time = 2;
                    }
                    //Third characters on the buttons 3 seconds
                    else if (words[j] == 'c' || words[j] == 'f' || words[j] == 'i' || words[j] == 'l' || words[j] == 'o' || words[j] == 'r' || words[j] == 'v' || words[j] == 'y')  
                    {
                        time = 3;
                    }
                    //Fourth caracters on the buttons require 4 seconds
                    else                                                                                                                                                 // Case where character is equal to 's'or 'z'
                    {
                        time = 4;
                    }
                    //Time required for  the current character added to the total time required for the current word
                    totalTime[i] += time;
                }

                //Effet of the position of the character in the word on the required time due to the "pause time"
                //Each character is compared to the previous character to know if they are on the same button in which we add 2 seconds to the required time

                for (int j = 1; j < words.Length; j++)     
                {
                    //Case of buttons with 4 characters on them
                    if (words[j]=='p' || words[j] == 'w')           
                    {
                        //There are 3 characters after them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] - 1 || words[j] == words[j - 1] - 2 || words[j] == words[j - 1] - 3)   
                        {
                            totalTime[i] += 2;

                        }
                    } else if (words[j] == 'q' || words[j] == 'x')  
                    {
                        //There are 2 characters after and 1 before them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] + 1 || words[j] == words[j - 1] - 1 || words[j] == words[j - 1] - 2)  
                        {
                            totalTime[i] += 2;

                        }
                    } else if (words[j] == 'r' || words[j] == 'y')  
                    {
                        //There are 2 characters before and 1 after them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] + 1 || words[j] == words[j - 1] +2 || words[j] == words[j - 1] - 1)   
                        {
                            totalTime[i] += 2;

                        }

                    }
                    //Case of buttons with 3 characters on them
                    else if (words[j] == 'a' || words[j] == 'd' || words[j] == 'g' || words[j] == 'j' || words[j] == 'm' || words[j] == 't')          
                    {
                        //There are 2 characters after them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] - 1 || words[j] == words[j - 1] - 2)
                        {
                            totalTime[i] += 2;

                        }
                    }else if (words[j] == 'b' || words[j] == 'e' || words[j] == 'h' || words[j] == 'k' || words[j] == 'n'|| words[j] == 'u')           
                    {
                        //There is 1 character before and 1 after them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] + 1 || words[j] == words[j - 1] - 1)
                        {
                            totalTime[i] += 2;

                        }
                    } else if (words[j] == 'c' || words[j] == 'f' || words[j] == 'i' || words[j] == 'l' || words[j] == 'o' || words[j] == 'v')          
                    {
                        //There are 2 characters before them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] + 1 || words[j] == words[j - 1] +2)
                        {
                            totalTime[i] += 2;

                        }
                    }
                    else         //Case where character is equal to 's' or 'z'                                                                                                                      
                    {
                        //There are 3 characters before them on the same button
                        if (words[j] == words[j - 1] || words[j] == words[j - 1] + 1 || words[j] == words[j - 1] + 2 || words[j] == words[j - 1] + 3)    
                        {
                            totalTime[i] += 2;

                        }
                    }

                }
            }

            //Final integer array containing the required time for each word before "halt"
            return totalTime;    
            
        }
          
       }

}
