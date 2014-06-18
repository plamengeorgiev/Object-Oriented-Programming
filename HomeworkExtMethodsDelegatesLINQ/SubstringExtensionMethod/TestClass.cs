using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtensionMethod
{
    class TestClass
    {
        static void Main(string[] args)
        {
            StringBuilder strBuilder = new StringBuilder();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            strBuilder.Append(alphabet);
            Console.WriteLine(strBuilder.ToString());
            StringBuilder newStrBuilder = strBuilder.Substring(15,5);
            Console.WriteLine(newStrBuilder.ToString());
        }
    }
}
