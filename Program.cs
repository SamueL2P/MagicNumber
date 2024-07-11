using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
            //A magic number is a direct usage of a number in the code.
            //In the below example '5' in the formula is an example of magic number.
            //If a magic number is used, whenever the rate changes,it has to be changed
            //everywhere it is mentioned manually.
            //It can lead to inconsistencies.
            //Instead an integer should be made named 'rate' and the value '5' should be stored in it.
            //It improves readability of the code and it's easier to maintain.

            static void Main(string[] args)
            {
                int principal = 1000;
                int time = 1;
                int rate = 5;

                // int simpleInterest = ((principal * 5 * time) / 100); wrong practice
                int simpleInterest = ((principal * rate * time) / 100);
                Console.WriteLine("Simple Intrest is : " + simpleInterest);
            }
    }
}
