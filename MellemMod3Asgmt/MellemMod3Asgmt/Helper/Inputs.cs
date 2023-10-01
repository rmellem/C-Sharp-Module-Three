using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    internal class Inputs
    {
        //can use this function
        public static int GetInt(string prompt)
        {
            bool isSuccess = false;
            int returnValue = 0;

            do
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                isSuccess = Int32.TryParse(userInput, out returnValue);

                if (!isSuccess)
                {
                    Console.WriteLine("You need to enter a whole number next time");
                }


            } while (!isSuccess);

            return returnValue;

        }
    
        public static char GetChar(string prompt, char[] possibleAnswers)
        {
            //watch out - may loop forever ... need to satisfy the data
            while (true)
            {
                Console.Write(prompt);
                //this may or may not be a string - could be NULL Either/OR
                string? userInput = Console.ReadLine();

                // make sure good data makes it to the database.
                if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Please make sure to enter a character");
                    continue;
                } else
                {
                    if (userInput.Length > 1)
                    {
                        Console.WriteLine("Please enter a single character");
                        continue;
                    }

                    if (possibleAnswers.Contains(userInput[0]))
                    {
                        return userInput[0];
                    } else
                    {
                        Console.WriteLine("Make sure to enter one of the following: "
                            + String.Join(", ", possibleAnswers));
                        continue;
                    }
                 
                }

            }

        }
    
    }

}


