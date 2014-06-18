using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class TestClass
    {
        static void Main()
        {
            School mySchool = new School();

            Class classOne = new Class();

            Teacher teacherOne = new Teacher("Ivan Ivanov");

            Discipline geometry = new Discipline("Geometry", 16, 25);
            geometry.Comments.Add("Basic Course");

            teacherOne.Disciplines.Add(geometry);
            teacherOne.Comments.Add("Senior teacher. 15 years of proffesional experience");

            classOne.Teachers.Add(teacherOne);
            mySchool.Classes.Add(classOne);
            
            Student pesho = new Student("Pesho", 20);
            pesho.Comments.Add("new student");

            classOne.Students.Add(pesho);
        }
    }
}
