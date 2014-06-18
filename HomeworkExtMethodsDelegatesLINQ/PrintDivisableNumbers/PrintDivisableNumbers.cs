using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDivisableNumbers
{
    class PrintDivisableNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine("Using lambda expression:");
            FindDivisableNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Using LINQ:");
            FindDivisableNumbersVar2(numbers);
        }

        public static void FindDivisableNumbers(int[] numbers)
        {
            var selectedNums = numbers.Where(x => x % 21 == 0);

            foreach (var number in selectedNums)
            {
                Console.Write("{0} ", number);
            }
        }

        public static void FindDivisableNumbersVar2(int[] numbers)
        {
            var selectedNumbers =
            from number in numbers
            where number % 21 == 0
            select number;

            foreach (var number in selectedNumbers)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
