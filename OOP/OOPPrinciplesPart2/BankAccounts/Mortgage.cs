namespace BankAccounts
{
    using System;

    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
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