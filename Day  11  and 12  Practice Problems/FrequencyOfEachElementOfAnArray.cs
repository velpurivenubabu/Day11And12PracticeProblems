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

            Dictionary<string,int> My_dict1 = new Dictionary<string, int>();
            
            foreach (string str in array)
            {
                //Console.WriteLine(str);
                if (My_dict1.ContainsKey(str))
                {
                    My_dict1[str]++;
                }
               else
                {
                    
                    My_dict1.Add(str, 1);
                    
                    
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
