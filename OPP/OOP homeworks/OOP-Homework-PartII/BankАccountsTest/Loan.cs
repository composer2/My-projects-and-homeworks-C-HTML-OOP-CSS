namespace BankАccountsTest
{
    internal class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public void DepositMoney(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (this.Customer is Individual && numberOfMonths > 3)
            {
                if (numberOfMonths - 3 < 0)
                {
                    return 0;
                }

                return base.CalculateInterestRate(numberOfMonths - 3);
            }
            else if (this.Customer is Company && numberOfMonths > 2)
            {
                if (numberOfMonths - 2 < 0)
                {
                    return 0;
                }
                return base.CalculateInterestRate(numberOfMonths - 2);
            }
            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
