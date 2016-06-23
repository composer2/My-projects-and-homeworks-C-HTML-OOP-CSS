namespace BankАccountsTest
{
    internal class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public void DepositMoney(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public void WithdrawMoney(decimal withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestRate(numberOfMonths);
        }

    }
}
