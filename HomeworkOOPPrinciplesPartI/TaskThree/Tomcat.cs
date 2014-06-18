using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Tomcat : Cat
    {
        //Contructors
        public Tomcat(string name, int age)
            : base(name, age, "male")
        {
        }

        //Methods
        public override void MakeSound()
        {
            Console.WriteLine("Mrrrrr...");
        }
    }
}
