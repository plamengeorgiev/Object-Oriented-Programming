using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayTask
{
    class TestClass
    {
        static void Main()
        {
            int num = 666;
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(64, '0'));
            ulong number = 666;
            Console.WriteLine("The First Array");
            BitArray64 firstArray = new BitArray64(number);

            foreach (var bit in firstArray)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            
            BitArray64 secondArray = new BitArray64((ulong)777);
            Console.WriteLine("The Second Array");
            foreach (var bit in secondArray)
            {
                Console.Write(bit);
            }
            Console.WriteLine();


            Console.WriteLine(firstArray.Equals(secondArray));  //tests Equals
            Console.WriteLine(firstArray == secondArray);   //tests ==
            Console.WriteLine(firstArray != secondArray);   //tests !=

            Console.WriteLine(firstArray);  //tests ToString

            Console.WriteLine(firstArray[0]);   //tests []
        }
    }
}
