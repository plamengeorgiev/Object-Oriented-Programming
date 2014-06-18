using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtensionMethod
{
    public static class ExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (index+length>strBuilder.Length)
            {
                throw new ArgumentException("Invalid input");
            }
            for (int i = index; i < index+length; i++)
            {
                result.Append(strBuilder[i]);
            }
            return result;
        }
    }
}
