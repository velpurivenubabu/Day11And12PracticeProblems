using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__11__and_12__Practice_Problems
{
    internal class Reverse_Each_Word_in_Sentence
    {
        public static void GetEachWordReverse(string string1)
        {
            string rec = "";
            foreach (char letter in string1) {
                //Console.WriteLine(letter);
                
                    rec = letter + rec;
                
                
            }
            Console.WriteLine(rec);
        }

    }
}
