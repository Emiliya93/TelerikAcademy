namespace BankAccounts
{
    using System;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer == Customer.Company && months <= 12)
            {
                return base.CalculateInterestAmount(months) / 2;
            }
            else if (this.Customer == Customer.Individual && months <= 6)
            {
                return 0;
            }

            return base.CalculateInterestAmount(months);
        }
    }
}