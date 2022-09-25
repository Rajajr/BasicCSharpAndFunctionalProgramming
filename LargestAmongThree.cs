using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class LargestAmongThree
    {
        public static void LargestAmongThreeNumbers()
        {
            // Find the Largest Among Three Numbers
            //variable
            int x = 0;
            int y = 0;
            int z = 0;

            Console.WriteLine("Enter any Three Number ");
            Console.WriteLine("X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Z");
            z = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z)
                Console.WriteLine("Given Number {0} is Largest",x);
            else if (y > x && x > z)
                Console.WriteLine("Given Number {0} is Largest",y);
            else if (z > x && z > y)
                Console.WriteLine("Given Number {0} is Largest",z);

        }
    }
}
