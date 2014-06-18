using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class TestClass
    {
        static void Main()
        {
            List<Animal> zoo = new List<Animal>()
            {
                new Animal("Tigyr", 6, "male"),
                new Animal("Lyv", 4, "male"),
                new Tomcat("Tom", 7),
                new Kitten("Myr",1),
                new Cat("Mich",2,"male"),
                new Frog("Kermit",1,"male"),
                new Dog("Banichko",4,"male"),
                new Dog("Pumiqrcho",6,"male")
            };

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.ToString());
                animal.MakeSound();
                Console.WriteLine();
            }
            Animal.PrintAverageAge(zoo);
        }
    }
}
