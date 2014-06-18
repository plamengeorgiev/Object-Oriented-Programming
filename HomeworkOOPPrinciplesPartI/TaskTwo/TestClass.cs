using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class TestClass
    {
        static void Main()
        {
            List<Student> people = new List<Student>();

            people.Add(new Student("Ivan", "Toshev", 2));
            people.Add(new Student("Stoyan", "ivanv", 3));
            people.Add(new Student("Petkan", "Stoyanov", 4));
            people.Add(new Student("Tarzan", "Petkanov", 5));
            people.Add(new Student("Kolio", "Tarzanov", 2));
            people.Add(new Student("Mimi", "Koleva", 6));
            people.Add(new Student("Pesho", "Marinov", 6));
            people.Add(new Student("Gosho", "Peshev", 4));
            people.Add(new Student("Tosho", "Goshev", 3));
            people.Add(new Student("Masho", "Toshev", 5));

            List<Student> orderedStudents = new List<Student>(people.OrderBy(x => x.Grade));

            Console.WriteLine("Students:");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", Grade: " + student.Grade);
            }

            List<Worker> workers = new List<Worker>()
        {
            new Worker("Ivan", "Toshev", 1,200),
            new Worker("Stoyan", "ivanv", 2,300),
            new Worker("Petkan", "Stoyanov", 3,400),
            new Worker("Tarzan", "Petkanov", 4,500),
            new Worker("Kolio", "Tarzanov", 5,600),
            new Worker("Mimi", "Koleva", 6,700),
            new Worker("Pesho", "Marinov", 5,400),
            new Worker("Gosho", "Peshev", 4,300),
            new Worker("Tosho", "Goshev", 3,200),
            new Worker("Masho", "Toshev", 2,100)
        };

            workers = new List<Worker>(workers.OrderByDescending(x => x.MoneyPerHour()));

            Console.WriteLine();
            Console.WriteLine("Workers:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + ", Salary: " + worker.MoneyPerHour());
            }

            List<Human> humans = new List<Human>(workers.Concat(new List<Human>(people)));
            humans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine();
            Console.WriteLine("Humans:");
            foreach (var human in humans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
