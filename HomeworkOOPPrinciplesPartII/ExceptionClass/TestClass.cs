using System;

namespace ExceptionClass
{
    class TestClass
    {
        static void PrintNumber()
        {
            //this method tests the exception using int number
            int min = 0;
            int max = 100;
            Console.WriteLine("Enter number in range {0}:{1}", min, max);
            int number = int.Parse(Console.ReadLine());
            if (number < min || number > max)
            {
                throw new InvalidRangeExeption<int>("The number is out of range!!!", min, max);
            }
            else
            {
                Console.WriteLine("The number {0} is valid!", number);
            }
        }
        static void PrintDate()
        {
            //this method tests the exception using DateTime
            DateTime min = new DateTime(1980, 1, 1);
            DateTime max = new DateTime(2013, 12, 31);
            Console.WriteLine("Enter date in range {0} - {1}", min, max);
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < min || date > max)
            {
                throw new InvalidRangeExeption<DateTime>("The date is out of range!!!", min, max);
            }
            else
            {
                Console.WriteLine("The date {0} is valid!", date);
            }
        }
        static void Main()
        {
            try
            {
                PrintNumber();
                PrintDate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
        }
    }
}
