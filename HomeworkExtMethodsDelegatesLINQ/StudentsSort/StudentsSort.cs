using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
    class StudentsSort
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            {
                students.Add(new Student("Ivan", "Ivanov"));
                students.Add(new Student("Dragan", "Georgiev"));
                students.Add(new Student("Petkan", "Petkanov"));
                students.Add(new Student("Tarzan", "Iliev"));
                Console.WriteLine("Using LINQ:");
                SortByNames(students);
                Console.WriteLine();
                Console.WriteLine("Using lambda expression:");
                SortByNamesVar2(students);

            };
            
        }

        public static void SortByNames(List<Student> students)
        {
            var sorted =
                from student in students
                orderby student.firstName, student.lastName
                select student;
            foreach (var student in sorted)
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
        }

        public static void SortByNamesVar2(List<Student> students)
        {
            var sorted = students.OrderBy(student => student.firstName).ThenBy(student => student.lastName);
            foreach (var student in sorted)
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
        }


    }
}
