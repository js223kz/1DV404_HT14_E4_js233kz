using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braktal
{
    class Program
    {
        static void Main(string[] args)
        {
            int denominator = 20;
            int numerator = 10;

            //Testing constructor
            WriteHeadline("Testar konstruktorn\n");
            Fraction constructorFraction = new Fraction(denominator, numerator);
            Console.WriteLine("{0}{1}{2}{3}", "Täljaren är: ", denominator, "\nNämnaren är: ", numerator);

            //Testing ToString method
            WriteHeadline("\nTestar ToString\n");
            Console.WriteLine("{0}{1}{2}{3}", "Täljaren är: ", denominator, "\nNämnaren är: ", numerator);
            Console.WriteLine(constructorFraction.ToString());

            //Testing if result is negative
            WriteHeadline("\nTestar isNegative\n");
            denominator = -20;
            numerator = 10;
            Console.WriteLine("{0}{1}{2}{3}", "Täljaren är: ", denominator, "\nNämnaren är: ", numerator);
            Console.WriteLine("{0}{1}", "Resultatet är negativt: ", constructorFraction.isNegative(denominator, numerator));

            //Testing if two results are equal or not
            WriteHeadline("\nTestar isEqualTo\n");
            double resultOne = constructorFraction.isEqualTo(10, 5);
            double resultTwo = constructorFraction.isEqualTo(20, 10);
            bool isEqual = false;

            Console.WriteLine("{0}{1}", "Första resultatet är: ", resultOne);
            Console.WriteLine("{0}{1}", "Andra resultatet är: ", resultTwo);

            if (resultOne == resultTwo)
            {
                isEqual = true;
                Console.WriteLine("{0}{1}", "Resultaten är lika: ", isEqual);
            }
            else
            {
                Console.WriteLine("{0}{1}", "Resultaten är lika: ", isEqual);
            }
        }

      
        static public void WriteHeadline(string headLine)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(headLine);
            Console.ResetColor();
        }
    }
}

            