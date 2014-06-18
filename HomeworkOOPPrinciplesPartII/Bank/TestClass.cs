using System;

namespace Bank
{
    class TestClass
    {
        static void Main(string[] args)
        {
            
            Individual ivan = new Individual("Ivan Ivanov");
            Company theCompany = new Company("The Company");

            DepositAccount firstDepositAccount = new DepositAccount(ivan, 1000m, 0.01m);
            DepositAccount secondDepositAccount = new DepositAccount(theCompany, 10000m, 0.01m);
            Console.WriteLine("First deposit balance:{0}", firstDepositAccount.Balance);
            firstDepositAccount.Draw(200m);
            Console.WriteLine("First deposit balance after the withdrawing:{0}", firstDepositAccount.Balance);
            firstDepositAccount.Deposit(200);
            Console.WriteLine("First deposit balance after the depositing:{0}", firstDepositAccount.Balance);

            Console.WriteLine("Second deposit balance:{0}", secondDepositAccount.Balance);
            secondDepositAccount.Draw(200m);
            Console.WriteLine("Second deposit balance after the withdrawing:{0}", secondDepositAccount.Balance);
            secondDepositAccount.Deposit(200);
            Console.WriteLine("Second deposit balance after the depositing:{0}", secondDepositAccount.Balance);

            Console.WriteLine("Type: {0} Customer:{1}-{2} Interest for the next six months: {3} "
                , firstDepositAccount.GetType().Name, firstDepositAccount.Customer.GetType().Name, firstDepositAccount.Customer.Name, firstDepositAccount.CalculateInterest(6));
            Console.WriteLine("Type: {0} Customer:{1}-{2} Interest for the next six months: {3} "
                , secondDepositAccount.GetType().Name, secondDepositAccount.Customer.GetType().Name, secondDepositAccount.Customer.Name, secondDepositAccount.CalculateInterest(6));
            
            LoanAccount firstLoanAccound = new LoanAccount(ivan, 1000m, 0.01m);
            Console.WriteLine("Type: {0} Customer:{1}-{2} Interest for the next six months: {3} "
                , firstLoanAccound.GetType().Name, firstLoanAccound.Customer.GetType().Name, firstLoanAccound.Customer.Name, firstLoanAccound.CalculateInterest(6));

            LoanAccount secondLoanAccount = new LoanAccount(theCompany, 10000m, 0.01m);
            Console.WriteLine("Type: {0} Customer:{1}-{2} Interest for the next six months: {3} "
                , secondLoanAccount.GetType().Name, secondLoanAccount.Customer.GetType().Name, secondLoanAccount.Customer.Name, secondLoanAccount.CalculateInterest(6));

            MortgageAccount firstMortageAccount = new MortgageAccount(ivan, 10000m, 0.01m);
            Console.WriteLine("Type: {0} Customer:{1}-{2} Interest for the next 24 months: {3} "
                , firstMortageAccount.GetType().Name, firstMortageAccount.Customer.GetType().Name, firstMortageAccount.Customer.Name, firstMortageAccount.CalculateInterest(24));
            MortgageAccount secondMortageAccount = new MortgageAccount(theCompany, 100000m, 0.01m);
            Console.WriteLine("Type: {0} Customer:{1}-{2} Interest for the next 24 months: {3} "
                , secondMortageAccount.GetType().Name, secondMortageAccount.Customer.GetType().Name, secondMortageAccount.Customer.Name, secondMortageAccount.CalculateInterest(24));
        }
    }
}
