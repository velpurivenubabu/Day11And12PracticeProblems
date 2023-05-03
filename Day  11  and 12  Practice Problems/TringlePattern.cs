using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class TringlePattern
    {
        public static void GetPattern(int number)
        {
            for (int i = 0; i < number; i++)
            {
                string pattern = new string('*', (number - i));
                Console.WriteLine(pattern);
            }   
        }
    }
}
