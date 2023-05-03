namespace Day__11__and_12__Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Practice Problems!");
            Console.WriteLine("Please Select any below Option");
            Console.WriteLine("1.InvertedRectangularPattern");
            int Option=Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                
                case 1:
                    Console.WriteLine("Please enter number of rows you want to print");
                    int number=Convert.ToInt32(Console.ReadLine());
                    TringlePattern.GetPattern(number);
                    break;
            }
        }
    }
}