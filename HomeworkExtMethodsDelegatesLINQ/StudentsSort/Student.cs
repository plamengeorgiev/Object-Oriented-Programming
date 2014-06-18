using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
    class Student
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Student(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

    }

}
