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
                   throw new ArgumentException("Nämnaren kan inte vara 0");
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
               _denominator = value;
           }
       }

       public Fraction(int denominator, int numerator){
           Numerator = numerator;
           Denominator = denominator;
       }

        public bool isNegative(int denominator, int numerator)
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

        public double isEqualTo(int denominator, int numerator)
        {
            Denominator = denominator;
            Numerator = numerator;
            double result = (double)Denominator / (double)Numerator;
            return result;   
        }

        public override string ToString()
        {
            double result = Denominator / Numerator;
            string stringResult = String.Format("{0}{1}", "Resultatet av bråktalet är: ", result);

            return stringResult;
        }
    }
}
