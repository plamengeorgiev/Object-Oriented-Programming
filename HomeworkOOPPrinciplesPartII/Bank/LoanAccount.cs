using System;

namespace Bank
{
    public class LoanAccount:Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (months - 2);
                }
            }
        }
    }
}
