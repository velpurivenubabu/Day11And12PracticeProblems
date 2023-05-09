using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class TotalNumberOfDuplecatesInASentenance
    {


        public static void GetDuplicates(string[] array)
        {
            var myList = new List<string>();
            var duplicates = new List<string>();

            foreach (string res in array)
            {
                if (!myList.Contains(res))
                {
                    myList.Add(res);
                }
                else
                {
                    if (!duplicates.Contains(res))
                    {
                        duplicates.Add(res);
                    }

                }
            }
            int count = 0;

            foreach (string result in duplicates)
            {
                count++;
                Console.WriteLine(result);
            }
            Console.WriteLine(count);
    }   }
}


