using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braktal
{
    class Fraction
    {
       private int _numerator;
       private int _denominator;
       //jw222hk@student.lnu.se och os222cq@student.lnu.se
       public int Numerator{
           get
           {
                return _numerator;
           }
           set
           {
               if (value == 0)
               {
                   throw new ArgumentException("Täljaren kan inte vara 0");
               }
               _numerator = value;
           }
       }

       public int Denominator{
           get

           {
               return _denominator;
           }
           set
           {
               if (value == 0)
               {
                   throw new ArgumentException("Nämnaren kan inte vara 0");
               }
               _denominator = value;
           }
       }

       public Fraction(int numerator, int denominator){
           Numerator = numerator;
           Denominator = denominator;
       }

        public bool isNegative(int numerator, int denominator)
       {
           Denominator = denominator;
           Numerator = numerator;
           double result = (double)Numerator / Denominator;

           if (result < 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

        public bool isEqualTo(Fraction firstObject, Fraction secondObject)
        {
            double firstResult = (double)firstObject.Numerator / firstObject.Denominator;
            double secondResult = (double)secondObject.Denominator / secondObject.Denominator;
            if (firstResult == secondResult)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }

        public string Add(Fraction firstObject, Fraction secondObject)
        {
            int numeratorResult = firstObject.Numerator + secondObject.Numerator;
            int denominatorResult = firstObject.Denominator + secondObject.Denominator;
            string stringResult = String.Format("{0}{1}{2}{3}", "Det nya bråktalet blir: ", numeratorResult, "/", denominatorResult);
            return stringResult;
        }

        public string Multiply(Fraction firstObject, Fraction secondObject)
        {
            int numeratorResult = firstObject.Numerator * secondObject.Numerator;
            int denominatorResult = firstObject.Denominator * secondObject.Denominator;
            string stringResult = String.Format("{0}{1}{2}{3}", "Det nya bråktalet blir: ", numeratorResult, "/", denominatorResult);
            return stringResult;
        }

        public override string ToString()
        {
            double result = Numerator / Denominator;
            string stringResult = String.Format("{0}{1}", "Resultatet av bråktalet är: ", result);

            return stringResult;
        }
    }
}
