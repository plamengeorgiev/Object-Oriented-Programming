﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
