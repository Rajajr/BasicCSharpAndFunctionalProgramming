using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class FindPrimeFactors
    {
        public static void PrimeNumbers()
        {
            //Find All The Factors of a Given Number
            //Variables
            int num = 0;
            int factor = 0;

            Console.WriteLine("Enter the Value of the Number : ");
            num=Convert.ToInt32(Console.ReadLine());
           
            for (factor = 1; factor < num; factor++)
            {
                if (num%factor == 0)
                {
                    Console.WriteLine(factor + ",");
                }
            }
            Console.ReadLine();
            
       
        }
    }
}
