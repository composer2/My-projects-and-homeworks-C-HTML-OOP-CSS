namespace BankАccountsTest
{
    internal class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public void DepositMoney(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestRate(numberOfMonths - 6);
                }
            }
            else if (this.Customer is Company)
            {
                if (numberOfMonths <= 12)
                {
                    return 0.5M * base.CalculateInterestRate(numberOfMonths);
                }
                else
                {
                    return 0.5M * base.CalculateInterestRate(12) + base.CalculateInterestRate(numberOfMonths - 12);
                }
            }
            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
