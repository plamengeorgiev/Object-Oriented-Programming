using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid interest rate!!!");
                }
                this.interestRate = value;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid amount of money!!!");
            }
            else
            {
                this.Balance += amount;
            }
        }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return (this.Balance * this.InterestRate) * months;
        }
    }
}
