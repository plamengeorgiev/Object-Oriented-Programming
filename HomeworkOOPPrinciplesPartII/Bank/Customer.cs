using System;

namespace Bank
{
    public class Customer
    {
        private string name;

        public string Name
        {
            get 
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
