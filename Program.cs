using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 : Swaping Two Numbers 
            //variables
            int x = 0;
            int y = 0;
            int result = 0;

            Console.WriteLine("Enter the x value");
            Console.WriteLine("x");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y value");
            Console.WriteLine("y");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swap x :{0},y :{1}", X, y);
            result = x;
            x = y;
            y = result;
            Console.WriteLine("After Swap x :{0},y :{1}", x, y);
            Console.ReadLine();


        }
    }
}
     
        


    



   
