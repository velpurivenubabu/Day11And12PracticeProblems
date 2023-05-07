namespace Day__11__and_12__Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Practice Problems!");
            Console.WriteLine("Please Select any below Option");
            Console.WriteLine("1.Inverted Tringle Pattern\n2.Rectangular Pattern\n3.Reverse Each Word in the List\n4.SumOfDigits\n5.FirstLetterCapital");
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
            }  
        }
    }
}