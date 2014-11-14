using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool valid = false;
            string[] userInputArray = new string[userInput.Length];

            int zeros = 0;
            int odd = 0;
            int even = 0;
            
            do
            {
                Console.Write("Mata in ett heltal: ");
                try
                {
                    userInput = Console.ReadLine();
                    valid = true;
                    userInputArray = userInput.Split(' ');

                    foreach (char letter in userInput)
                    {
                        int charSign = int.Parse(letter.ToString());
                        if (charSign == 0)
                        {
                            zeros++;
                        }
                        if (charSign % 2 == 0 && charSign !=0)
                        {
                            even++;
                        }
                        if (charSign % 2 != 0)
                        {
                            odd++;
                        }
                        
                    }
                    Console.WriteLine("Antal Nollor: " + zeros);
                    Console.WriteLine("Jämna siffror: " + even);
                    Console.WriteLine("Udda siffror: " + odd);
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Talet måste vara ett heltal skrivet med siffror");
                    Console.WriteLine();
                    Console.ResetColor();
                } 
            } while (valid == false);
        }
    }
}
