using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";           
            Console.Write("Mata in 10 heltal: ");
            userInput = Console.ReadLine();
            int maxValue = 0;
            int currentNumber = 0;
            int secondLargest = 0;
            
            string regexPattern = @"-?[\d]+";

            foreach (Match match in Regex.Matches(userInput, regexPattern))
            {
                currentNumber = Convert.ToInt32(match.Value);
                if (currentNumber > maxValue)
                {
                    secondLargest = maxValue;
                    maxValue = currentNumber;
                }
                if(currentNumber < maxValue)
                {
                    secondLargest = currentNumber;
                }
             }
            Console.WriteLine("Det näststörsta talet är: " + secondLargest);   
          
        }
    }
}
