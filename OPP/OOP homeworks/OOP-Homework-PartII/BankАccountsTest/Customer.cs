namespace BankАccountsTest
{
    using System;
    using System.Text;

    internal abstract class Customer
    {
        private string name;

        public Customer() { }
        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Must enter a valid name.");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            var client = new StringBuilder();
            client.AppendFormat("{0}: {1}", this.GetType().Name, this.name);
            client.AppendLine();
            return client.ToString(); 
        }
    }
}
