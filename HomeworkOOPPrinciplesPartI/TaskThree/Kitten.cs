﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "female")
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mqqqk...");
        }
    }
}
