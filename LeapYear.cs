using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class LeapYear
    {
        public static void LeapYearOrNot()
        {
            int year = 0;
            Console.WriteLine("Enter the year :- ");
            year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("Year : {0} is Leap Year", +year);
            }

            else 

            {
                Console.WriteLine("Year : {0} is not a Leap Year", +year);
            }
            

        }
    }
}
            
        
