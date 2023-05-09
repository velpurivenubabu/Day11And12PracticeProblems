using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class FrequencyOfEachElementOfAnArray
    {
        public static void GetFrequencyOfEachElement(string[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                var x = array[i];
                var j = i;
                while (j > 0 && array[j - 1].CompareTo(x) > 0)
                {
                    array[j] = array[j - 1];
                    j = j - 1;
                }
                array[j] = x;
            }
            Dictionary<string,int> My_dict1 = new Dictionary<string, int>();
            int count = 0;
            foreach (string str in array)
            {
                //Console.WriteLine(str);
                if (My_dict1.ContainsKey(str))
                {
                    count++;

                    My_dict1[str] = count;
                }
               else
                {
                    count = 1;
                    My_dict1.Add(str, count);
                    
                    
                }
            }
            foreach (var kvp in My_dict1)
            {
                string word = kvp.Key;
                int count1 = kvp.Value;

                Console.WriteLine($"{word} : {count1}");
            }
        }
    }
}
