using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    public class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;

        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                if (value != "male")
                {
                    if (value != "female")
                    {
                        throw new ArgumentOutOfRangeException("Sex must be male OR female!");
                    }
                }
                this.sex = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid name!!!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid age!!!");
                }
                this.age = value;
            }
        }

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("I am: " + this.GetType());
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: " + this.Name);
            result.AppendFormat("\nAge: " + this.Age);
            result.AppendFormat("\nSex: " + this.Sex);
            return result.ToString();
        }

        public static Dictionary<string, double> CalculateAverageAge(List<Animal> animals)
        {
            Dictionary<string, double> ages = new Dictionary<string, double>();

            Dictionary<string, double> animalCounters = new Dictionary<string, double>();

            Dictionary<string, double> result = new Dictionary<string, double>();

            foreach (var animal in animals)
            {
                string key = animal.GetType().ToString();
                if (!ages.ContainsKey(key))
                {
                    ages.Add(key, animal.Age);
                    animalCounters.Add(key, 1);
                }
                else
                {
                    ages[key] = ages[key] + animal.Age;
                    animalCounters[key]++;
                }
            }

            foreach (var animal in ages)
            {
                result.Add(animal.Key, (animal.Value / animalCounters[animal.Key]));
            }
            return result;
        }

        public static void PrintAverageAge(List<Animal> animals)
        {
            foreach (var animal in CalculateAverageAge(animals))
            {
                Console.WriteLine("Animal: {0} - Average Age: {1}", animal.Key.ToString().PadRight(10), animal.Value);
            }
        }
    }
}
