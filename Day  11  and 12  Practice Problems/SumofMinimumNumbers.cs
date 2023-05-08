using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class SumofMinimumNumbers
    {
        public static void GetSumOfTwoMinNumbers(string[] array)
        {
            int minNumber1 = Convert.ToInt32(array[0]);
            foreach (string num in array) {
                int num1 = Convert.ToInt32(num);
                if(num1 <minNumber1 && num1>=0) {
                    minNumber1 = num1;
                }
            }
            int minNumber2= Convert.ToInt32(array[1]);
            foreach (string num in array)
            {
                int num2 = Convert.ToInt32(num);
                if (num2 < minNumber1 && num2 >= 0 && num2>minNumber1)
                {
                    minNumber2 = num2;
                }

            }
            Console.WriteLine(minNumber1 + minNumber2);
        }

    }
}
