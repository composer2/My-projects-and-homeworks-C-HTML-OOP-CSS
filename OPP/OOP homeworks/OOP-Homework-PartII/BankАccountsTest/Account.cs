namespace BankАccountsTest
{
    using System;
    using System.Text;

    internal abstract class Account
    {
        private decimal balance;
        public decimal InterestRate { get; private set; }
        public Customer Customer { get; private set; }


        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.balance = balance;
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException("Account balance can't be less than 0");
                }
                this.balance = value;
            }
        }

        public virtual decimal CalculateInterestRate(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }

        public override string ToString()
        {
            var account = new StringBuilder();
            account.AppendFormat("Client Type: {0}", this.Customer.GetType().Name);
            account.AppendLine();
            account.AppendFormat("Client name: {0}", this.Customer.Name);
            account.AppendLine();
            account.AppendFormat("Account balance {0}", this.Balance);
            account.AppendLine();
            account.AppendFormat("Interest rate: {0}", this.InterestRate);
            account.AppendLine();
            
            return account.ToString();
        }
    }
}
