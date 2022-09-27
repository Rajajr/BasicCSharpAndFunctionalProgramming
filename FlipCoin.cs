using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class FlipCoin
    {
        public static void CoinFlips()
        {
            //Flip Coin and Print Percentage oF Head and Tails
            //variables
            int num = 0;
            int Flip1 = 0;
            int Flip2 = 0;
            double HEAD = 0;
            double Tail = 0;

            //Random check
            Random random = new Random();
            Console.WriteLine("Enter The Number to Flip the coin");
            num=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var result=random.Next(0,2);
                if (result < 0.5)
                {
                    Flip1++;
                }
                else
                {
                    Flip2++;
                }
            }
            HEAD = (Flip1 * 100 / num);
            Tail = (Flip2 * 100 / num);
            Console.WriteLine("(Head) percentage is : {0}% and (Tail) percentage is : {1}%", HEAD, Tail);
            
        }

    }
}
