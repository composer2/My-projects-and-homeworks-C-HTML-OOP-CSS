using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;

        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
            private set
            {
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            private set { this.usage = value; }
        }


        public  string Print()
        {
            var shampoo = new StringBuilder();
            shampoo.AppendFormat("Quantity: {0} ml", this.Milliliters);
            shampoo.AppendFormat("Usage: {0} ml",this.Usage);
            return shampoo.ToString();
        }
    }
}
