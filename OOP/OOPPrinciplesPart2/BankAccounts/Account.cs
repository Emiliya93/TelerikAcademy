namespace BankAccounts
{
    using System;

    public class Account
    {
        // Fields
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        // Constructor
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;

        }

        // Properties
        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                if (value != Customer.Individual || value != Customer.Company)
                {
                    throw new NotSupportedException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                this.interestRate = value;
            }
        }

        // Methods
        public void Deposit(decimal money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid sum to deposit!");
            }

            this.balance += money;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            decimal amount = 0;
            amount = months * this.interestRate;

            return amount;
        }
    }
}