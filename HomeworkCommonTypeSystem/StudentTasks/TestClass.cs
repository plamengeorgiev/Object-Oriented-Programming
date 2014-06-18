using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTasks
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Ivan", "Ivanov", "Peshev", 9029394852, "Studentski Grad bl42", 3849384398,
                "ivancho@abv.bg", 3, University.SU, Faculty.MathematicsFaculty, Specialty.Mathematics );

            Student secondStudent = new Student("Pesho", "Peshev", "Peshev", 9029485212, "Imaginary Str 44", 39483439,
                "pesho@abv.bg", 3, University.UNSS, Faculty.EconomicsFaculty, Specialty.Economics);

            Console.WriteLine("firstStudent HashCode: " + firstStudent.GetHashCode());
            Console.WriteLine("secondStudent HashCode: " + secondStudent.GetHashCode());
            Console.WriteLine("firstStudent equals secondStudent: " + firstStudent.Equals(secondStudent));
            Console.WriteLine("firstStudent == secondStudent: " + (firstStudent == secondStudent));
            Console.WriteLine("firstStudent != secondStudent: " + (firstStudent != secondStudent));
            Console.WriteLine(secondStudent.ToString());
            Student thirdStudent = (Student)secondStudent.Clone();
            Console.WriteLine("secondStudent == thirdStudent: " + (secondStudent == thirdStudent));
            Console.WriteLine("secondStudent != thirdStudent: " + (secondStudent != thirdStudent));
            Console.WriteLine("secondStudent.CompareTo(thirdStudent): " + secondStudent.CompareTo(thirdStudent));
            Console.WriteLine("firstStudent.CompareTo(secondStudent): " + firstStudent.CompareTo(secondStudent));
        }
    }
}
