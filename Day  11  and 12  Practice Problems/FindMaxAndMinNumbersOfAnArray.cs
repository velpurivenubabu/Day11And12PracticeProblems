using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class FindMaxAndMinNumbersOfAnArray
    {
        public static void GetMinAndMax(string[] arry5)
        {
            int minNumber = Convert.ToInt32(arry5[0]);
            int maxNumber = Convert.ToInt32(arry5[0]);
            foreach (string num in arry5)
            {
                if (minNumber >= Convert.ToInt32(num))
                {
                    minNumber=Convert.ToInt32(num);
                }
                if (maxNumber <= Convert.ToInt32(num))
                {
                    maxNumber = Convert.ToInt32(num);
                }
            }
            Console.WriteLine($"Minimum Number:{minNumber}\nMaximum Number : {maxNumber}");

        }
    }
}
