using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Please choose any one program from below option");
            Console.WriteLine("1:Vowel or Consontant\n2:Find Largest Among Three Numbers\n3:Find Prime Factor\n4:Flip The Coin\n5:Leap Year");
            int option=Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter any Letters To Check Vowels Or Constant");
                    string input = Console.ReadLine();
                    VowelsOrConsonant.VowelConstant(input);
                    break;

                case 2:
                    LargestAmongThree.LargestAmongThreeNumbers();
                    break;

                case 3:
                    FindPrimeFactors.PrimeNumbers();
                    break;

                case 4:
                    FlipCoin.CoinFlips();
                    break;

                case 5:
                    LeapYear.LeapYearOrNot();
                    break;

                default:
                    Console.WriteLine("Please Enter the Number Within Range");
                    break;

            }

            Console.ReadLine();
        }
    }
           
}
     
     


    



   
