namespace BankAccounts
{
    using System;

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public decimal WithDraw(decimal money)
        {
            if (money > this.Balance)
            {
                throw new ArgumentOutOfRangeException("There is no such amount in deposit account!");
            }

            this.Balance -= money;

            return money;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount(months);
        }
    }
}