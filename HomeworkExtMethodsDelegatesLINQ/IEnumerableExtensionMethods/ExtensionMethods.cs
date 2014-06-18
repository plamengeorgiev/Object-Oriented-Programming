using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethods
{
    public static class ExtensionMethods
    {
        public static decimal Sum<T>(this IEnumerable<T> data)
        {
            decimal result = 0;
            foreach (var item in data)
            {
                result += Convert.ToDecimal(item);
            }
            return result;
        }
        public static decimal Product<T>(this IEnumerable<T> data)
        {
            decimal result = 1;
            foreach (var item in data)
            {
                result *= Convert.ToDecimal(item);
            }
            return result;
        }
        public static decimal Min<T>(this IEnumerable<T> data)
        {
            decimal result = decimal.MaxValue;
            foreach (var item in data)
            {
                decimal value = Convert.ToDecimal(item);
                if (value < result)
                {
                    result = value;
                }
            }
            return result;
        }
        public static decimal Max<T>(this IEnumerable<T> data)
        {
            decimal result = decimal.MinValue;
            foreach (var item in data)
            {
                decimal value = Convert.ToDecimal(item);
                if (value > result)
                {
                    result = value;
                }
            }
            return result;
        }
        public static decimal Average<T>(this IEnumerable<T> data)
        {
            decimal result = 0;
            int counter = 0;
            foreach (var item in data)
            {
                counter++;
                result += Convert.ToDecimal(item);
            }
            return result/counter;
        }
    }
}
