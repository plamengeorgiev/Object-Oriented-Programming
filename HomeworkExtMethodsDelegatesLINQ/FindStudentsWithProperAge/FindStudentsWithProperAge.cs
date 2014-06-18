using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStudentsWithProperAge
{
    class FindStudentsWithProperAge
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            {
                students.Add(new Student("Ivan", "Ivanov", 17));
                students.Add(new Student("Dragan", "Georgiev", 19));
                students.Add(new Student("Petkan", "Petkanov", 23));
                students.Add(new Student("Tarzan", "Iliev", 30));
            };
            FindStudentsBetween(students);
        }

        static void FindStudentsBetween(List<Student> students)
        {
            var selectedStudents =
            from student in students
            where student.age >= 18 && student.age <= 24
            select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }

}
