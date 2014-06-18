using System;

namespace Bank
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (months - 6);
                }
            }
            else
            {
                if (months <= 12)
                {
                    return (this.Balance * (this.InterestRate / 2)* months);
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 2) * 12) + (this.Balance * this.InterestRate) * (months - 12);
                }
            }
        }
    }
}
