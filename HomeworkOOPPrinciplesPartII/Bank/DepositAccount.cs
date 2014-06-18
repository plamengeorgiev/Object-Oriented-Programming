using System;

namespace Bank
{
    public class DepositAccount:Account, IDepositable, IDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public void Draw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid amount of money!!!");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return 0;
            }
            else
            {
                return (this.Balance * this.InterestRate) * months;
            }
        }
    }
}
