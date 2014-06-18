using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Pesho");
            Person secondPerson = new Person("Ivan", 29);
            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);

        }
    }
}
