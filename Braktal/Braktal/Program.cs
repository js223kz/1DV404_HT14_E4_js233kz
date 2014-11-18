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
            try
            {
                int numerator = 20;
                int denominator = 10;
                Fraction firstFraction = new Fraction(numerator, denominator);
                Fraction secondFraction;

                //Testing constructor
                WriteHeadline("Testar konstruktorn\n");
                Console.WriteLine("{0}{1}{2}{3}", "Täljaren är: ", numerator, "\nNämnaren är: ", denominator);

                //Testing ToString method that prints result of fraction
                WriteHeadline("\nTestar ToString\n");
                Console.WriteLine("{0}{1}{2}{3}", "Täljaren är: ", numerator, "\nNämnaren är: ", denominator);
                Console.WriteLine(firstFraction.ToString());

                //Testing if result is negative
                WriteHeadline("\nTestar isNegative\n");
                numerator = -20;
                denominator = 10;
                Console.WriteLine("{0}{1}{2}{3}", "Täljaren är: ", numerator, "\nNämnaren är: ", denominator);
                Console.WriteLine("{0}{1}", "Resultatet är negativt: ", firstFraction.isNegative(numerator, denominator));

                //Testing if two results are equal or not
                WriteHeadline("\nTestar isEqualTo\n");
                secondFraction = new Fraction(20, 3);
                Console.WriteLine("{0}{1}{2}{3}", "Första talets täljare är: ", firstFraction.Numerator, "\nFörsta talets nämnare är: ", firstFraction.Denominator);
                Console.WriteLine("{0}{1}{2}{3}", "Andra talets täljare är: ", secondFraction.Numerator, "\nAndra talets nämnare är: ", secondFraction.Denominator);
                Console.WriteLine("{0}{1}", "Bråkens resultat är lika: ", firstFraction.isEqualTo(firstFraction, secondFraction));

                //Testing to add two fractions
                WriteHeadline("\nTestar att addera två bråktal\n");
                firstFraction.Numerator = 3;
                firstFraction.Denominator = 10;
                Console.WriteLine("{0}{1}{2}{3}", "Första talets täljare är: ", firstFraction.Numerator, "\nAndra talets nämnare är: ", secondFraction.Numerator);
                Console.WriteLine("{0}{1}{2}{3}", "Första talets täljare är: ", firstFraction.Denominator, "\nAndra talets nämnare är: ", secondFraction.Denominator);
                Console.WriteLine(firstFraction.Add(firstFraction, secondFraction));

                //Testing to multiply two fractions
                WriteHeadline("\nTestar att multiplicera två bråktal\n");
                Console.WriteLine("{0}{1}{2}{3}", "Första talets täljare är: ", firstFraction.Numerator, "\nAndra talets täljare är: ", secondFraction.Numerator);
                Console.WriteLine("{0}{1}{2}{3}", "Första talets täljare är: ", firstFraction.Denominator, "\nAndra talets nämnare är: ", secondFraction.Denominator);
                Console.WriteLine(firstFraction.Multiply(firstFraction, secondFraction));

                //Testing to throw in zero;
                WriteHeadline("\nTestar att skicka in 0 som argument\n");
                firstFraction.Numerator = 5;
                firstFraction.Denominator = 0;
            }
            catch (ArgumentException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
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

            