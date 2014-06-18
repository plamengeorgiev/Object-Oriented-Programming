using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            string message =string.Format("Name: {0}, ",Name) ;
            if (age == null)
            {
                message += "age not specified";
            }
            else
                message += Age;

            return message;
        }

    }
}
