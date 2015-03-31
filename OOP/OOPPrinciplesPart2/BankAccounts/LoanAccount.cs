namespace BankAccounts
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer == Customer.Individual && months <= 3)
            {
                return 0;
            }
            else if (this.Customer == Customer.Company && months <= 2)
            {
                return 0;
            }

            return base.CalculateInterestAmount(months);
        }
    }
}