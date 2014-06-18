using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethods
{
    class TestClass
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 5, 6, 7, 8, 23, -12432, 54, 3, 23, 4 };
            double[] secondArr = new double[] {4.3, 7.8, 2.9, 5.7, 1.8, 6.2, 123, 453, -23};

            Console.WriteLine("Sum:{0}", arr.Sum());
            Console.WriteLine("Product:{0}", arr.Product());
            Console.WriteLine("Min value:{0}", arr.Min());
            Console.WriteLine("Max value:{0}", arr.Max());
            Console.WriteLine("Average:{0}", arr.Average());

            Console.WriteLine("Sum:{0}",secondArr.Sum());
            Console.WriteLine("Product:{0}", secondArr.Product());
            Console.WriteLine("Min value:{0}", secondArr.Min());
            Console.WriteLine("Max value:{0}", secondArr.Max());
            Console.WriteLine("Average:{0}", secondArr.Average());
            
        }
    }
}
