using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class AllUniqueElementsInaList
    {
        public static void GetAllUniqueElements(string[] array)
        {
            var myList = new List<string>();
            var duplicates = new List<string>();

            foreach (string res in array)
            {
                if (!myList.Contains(res))
                {
                    myList.Add(res);
                }

            }
            foreach (string result in myList)
            {
                Console.Write(result + " ");
            }
        }
    }
}
