using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTasks
{
    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong ssn;
        private string address;
        private ulong phoneNumber;
        private string email;
        private int course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public ulong SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public ulong PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }


        public Student(string firstName, string middleName, string lastName, ulong ssn, string address, ulong phoneNumber,
        string email, int course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Student - {0} {1} {2} , SSN: {3}", this.FirstName, this.MiddleName, this.LastName, this.SSN);
        }

        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                this.PhoneNumber, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

            return result;
        }

        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN.CompareTo(student.SSN));
            }
            return 0;
        }
    }
}
