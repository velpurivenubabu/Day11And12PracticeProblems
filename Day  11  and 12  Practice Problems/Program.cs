using System;
using System.Collections.Immutable;
using System.Globalization;

namespace Day__11__and_12__Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Practice Problems!");
            Console.WriteLine("Please Select any below Option");
            Console.WriteLine("1.Inverted Tringle Pattern\n2.Rectangular Pattern\n3.Reverse Each Word in the List\n4.SumOfDigits\n5.FirstLetterCapital\n6.SumOfTwoMinimalNumbers\n7.GetDupicates\n8.Find All Unique Elements In the Sentence\n9.Find Frequence of Given Elements In a list\n10.Find Max and Min Numbers Of An Array");
            int Option=Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {

                case 1:
                    Console.WriteLine("Please enter number of rows you want to print");
                    int number = Convert.ToInt32(Console.ReadLine());
                    TringlePattern.GetPattern(number);
                    break;
                case 2:
                    Console.WriteLine("Please enter number of rows you want to print");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    RectangularPattern.GetRectanglePattern(number1);
                    break;
                case 3:
                    Console.WriteLine("Please type the sentence witch you want to reverse");
                    string string1 = Console.ReadLine();
                    Reverse_Each_Word_in_Sentence.GetEachWordReverse(string1);
                    break;
                case 4:
                    Console.WriteLine("Please type the Number witch you want to Sum of digits");
                    string string2 = Console.ReadLine();
                    SumOfDigits.GetSumOfDigits(string2);
                    break;
                case 5:
                    Console.WriteLine("Please type the sentence witch you want to Make as First Letter Capital");
                    string string3 = Console.ReadLine();
                    FirstLetterCapital.FirstLetter(string3);
                    break;
                case 6:
                    Console.WriteLine("Please Enter the Numbers Randomly With Sapace");
                    string string4= Console.ReadLine();
                    string[] arry1 = string4.Split(" ");
                    SumofMinimumNumbers.GetSumOfTwoMinNumbers(arry1);
                    break;
                case 7:
                    Console.WriteLine("Please Enter the Sentenance");
                    string string5 = Console.ReadLine();
                    string[] arry2 = string5.Split(" ");
                    TotalNumberOfDuplecatesInASentenance.GetDuplicates(arry2);
                    break;
                case 8:
                    Console.WriteLine("Please Enter the Sentenance");
                    string string6 = Console.ReadLine();
                    string[] arry3 = string6.Split(" ");
                    AllUniqueElementsInaList.GetAllUniqueElements(arry3);
                    break;
                case 9:
                    Console.WriteLine("Please Enter the Sentenance");
                    string string7 = Console.ReadLine();
                    string[] arry4 = string7.Split(" ");
                    
                    FrequencyOfEachElementOfAnArray.GetFrequencyOfEachElement(arry4);
                    break;
                case 10:
                    Console.WriteLine("Please Enter the Sentenance");
                    string string8 = Console.ReadLine();
                    string[] arry5 = string8.Split(" ");
                    FindMaxAndMinNumbersOfAnArray.GetMinAndMax(arry5);
                    break;
            }  
        }
    }
}