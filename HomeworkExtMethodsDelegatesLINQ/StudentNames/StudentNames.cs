using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNames
{
    class StudentNames
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            {
                students.Add(new Student("Ivan", "Ivanov"));
                students.Add(new Student("Dragan", "Georgiev"));
                students.Add(new Student("Petkan", "Petkanov"));
                students.Add(new Student("Tarzan", "Iliev"));
            };
            FindStudents(students);
        
        }
        static void FindStudents(List<Student> students)
        {
            var selectedStudents =
            from student in students
            where student.firstName.CompareTo(student.lastName) == -1
            select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine("{0} {1}", student.firstName,  student.lastName);
            }
        }
        
    }
}
