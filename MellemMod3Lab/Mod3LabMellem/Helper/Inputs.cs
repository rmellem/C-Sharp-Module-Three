using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3LabMellem.Helper
{
    internal class Inputs
    {
        //can use this function
        public static int GetInt(string prompt)
        {
            int returnValue = 0;

            Console.Write(prompt);      
            string userInput = Console.ReadLine();

            

            bool isSuccess = Int32.TryParse(userInput, out returnValue);

            if (!isSuccess)
            {
                Console.WriteLine("You need to enter a whole number next time");
            }
            return returnValue;
        }
    }
}
