namespace BankАccountsTest
{
    using System.Collections.Generic;
    using System.Text;
    
  internal  class Bank
    {
        public List<Account> Accounts { get; set; }

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            if (!this.Accounts.Contains(account))
            {
                throw new System.ArgumentException("Account does not exist");
            }
            this.Accounts.Add(account);
        }

        public override string ToString()
        {
            var accounts = new StringBuilder();
            accounts.AppendLine("Bank accounts: ");

            var counter = 1;
            foreach (var item in this.Accounts)
            {
                accounts.AppendFormat("Acount{0}: ", counter);
                accounts.AppendLine(new string('*', 40));
                accounts.AppendLine(item.ToString());
            }
            return accounts.ToString();
        }
    }
}
