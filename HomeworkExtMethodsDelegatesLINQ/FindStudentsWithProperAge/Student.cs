using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStudentsWithProperAge
{
    class Student
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public int age { get; private set; }

        public Student(string FirstName, string LastName, int Age)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.age = Age;
        }

    }

}
