using Cosmetics.Contracts;
using System;
using Cosmetics.Common;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste, IProduct
    {

        private const int maxSymbols = 12;
        private const int minSymbols = 4;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.Ingredients = ingredients;
        }


        public ICollection<string> Ingredients
        {
            get
            {
                return new List<string>(this.Ingredients);
            }
            set
            {
                this.Ingredients = value;
            }
        }

        public string Print()
        {
            var toothpaste = new StringBuilder();
            toothpaste.AppendFormat("Quantity: {0} ml", string.Join(", ", Ingredients));
            return toothpaste.ToString();
        }
    }
}
