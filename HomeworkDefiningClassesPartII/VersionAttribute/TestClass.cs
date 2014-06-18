using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version(1, 2)]
    class TestClass
    {
        static void Main(string[] args)
        {
            Type type = typeof(TestClass);
            Console.WriteLine("Class: {0}", type.Name);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in allAttributes)
            {
                VersionAttribute version = (VersionAttribute)attribute;
                Console.WriteLine("Version: {0}", version.GetVersion);
            }
        }
    }
}
