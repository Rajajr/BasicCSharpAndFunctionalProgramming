using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpandFunctional
{
    public class VowelsOrConsonant
    {
       public static void VowelConstant(string input)
        {
            //3:Check the Letter Vowels Or Consonant
           
            if (input.ToLower().Equals("a") || input.ToLower().Equals("e") || input.ToLower().Equals("i") || input.ToLower().Equals("o") || input.ToLower().Equals("u") || input.ToLower().Equals("y"))
                
                Console.WriteLine("Given Letter {0} is Vowel", input);
            else
                Console.WriteLine("Given Letter {0} is Constant", input);

        }
    }
}
