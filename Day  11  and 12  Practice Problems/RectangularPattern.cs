using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class RectangularPattern
    {
        public static void GetRectanglePattern(int number1)
        {
            for (int i = 0; i < number1; i++)
            {
                if (i == 0 || i == number1 - 1)
                {
                    string pattern = new string('*', (number1));
                    Console.WriteLine(pattern);
                    Console.WriteLine();
                }
                else
                {
                    string space = new string(' ', (number1-2));
                    Console.WriteLine("*"+space+"*");
                    Console.WriteLine();
                }
            }
        }
    }
}
