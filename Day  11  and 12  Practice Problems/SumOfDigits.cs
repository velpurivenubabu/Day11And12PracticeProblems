using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class SumOfDigits
    {
        
        public static void GetSumOfDigits(string string2)
        {
            int sum = 0;
            foreach (char digit in string2 )
            {
                //Console.WriteLine(digit);
                string num1= digit.ToString();
                int num = Convert.ToInt32(num1);
               // Console.WriteLine(num);
                sum+= num;
            }
            Console.WriteLine(sum);
        }
    }
}
