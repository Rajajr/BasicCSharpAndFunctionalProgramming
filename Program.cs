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
            //2 :Check Wether a Number is Even Or Odd 
            //variables
            int num = 0;
          
            Console.WriteLine("Please enter the Number");
            num = Convert.ToInt32(Console.ReadLine());

            if ( num%2 == 0)

                Console.WriteLine("Given Number is Even", num);
            else
                Console.WriteLine("Given Number is Odd", num);
            
            Console.ReadLine();


        }
    }
}
     
        


    



   
