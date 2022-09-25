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
            //Find Prime Factors Numbers
            //Variables
            int factor=0;
            int num = 0;
            Random random = new Random();
            Console.WriteLine("enter the number");
           
            for (int i = 0; i <= 10; i++)
            {
                num = random.Next(1,11);
                Console.WriteLine(num);
            }
            for (int i = 1; i <= num; i++)
            {
                if(num % i== 0)
                {
                    factor = factor + 1; 
                }
            }
            if (factor>2)
            {
                Console.WriteLine("Given Number {0} is not prime", num);
            }
            else
            {
                Console.WriteLine("Given Number {0} is prime", num);
            }

            

        }
    }
}
