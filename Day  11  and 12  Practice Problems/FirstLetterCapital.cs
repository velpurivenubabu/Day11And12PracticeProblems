using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class FirstLetterCapital
    {
        public static void FirstLetter(string string3)
        {
            string rec = "";
            string[] array1 = string3.Split(" ");
            foreach (string s in array1)
            {
                string st = s[0].ToString();
                st=st.ToUpper();
                rec += st;
                //Console.WriteLine(rec);
                
                for (int i = 1; i < s.Length; i++)
                {
                    rec += s[i];
                }

                rec += " ";
            }

            Console.WriteLine(rec);
        }
    }
}
