using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = "";
            bool valid = false;

            Console.WriteLine("Testa om ett ord är ett palindrom.");
            
            do
            {
                try
                {
                    Console.Write("Skriv in ett ord: ");
                    userInput = Console.ReadLine().ToLower();
                    string reversed = new string(userInput.ToCharArray().Reverse().ToArray());

                    if (userInput == "")
                    {
                        throw new FormatException("Du måste skriva in ett ord!");
                    }

                    if (reversed == userInput)
                    {
                        Console.WriteLine("{0}{1}", userInput, " är ett palindrom");
                        Console.WriteLine();
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}", userInput, " är inte ett palindrom");
                        Console.WriteLine();
                        valid = true;
                    }
                    
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Tryck valfri tangent för att fortsätta. Esc avslutar");
                    Console.WriteLine();
                    Console.ResetColor();
                    
                }
                catch (FormatException ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Console.ResetColor();
                } 
            } while (valid == false || Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
