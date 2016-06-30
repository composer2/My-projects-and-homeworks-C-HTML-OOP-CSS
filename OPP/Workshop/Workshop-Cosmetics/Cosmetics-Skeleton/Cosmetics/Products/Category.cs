using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private const int minSymbols = 2;
        private const int maxSymbols = 15;
        private string name;
        private ICollection<IProduct> productsList;

        public List<IProduct> ProductsList { get; private set; }

        public Category(string name)
        {
            this.Name = name;
            this.ProductsList = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {

                Validator.CheckIfStringLengthIsValid(value, maxSymbols, minSymbols, string.Format(GlobalErrorMessages.InvalidStringLength, this.GetType().Name + " name", minSymbols, maxSymbols));
                this.name = value;
            }
        }


        public void AddCosmetics(IProduct cosmetics)
        {
            this.ProductsList.Add(cosmetics);
        }


        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!productsList.Contains(cosmetics))
            {
                string.Format(GlobalErrorMessages.InvalidProductName, cosmetics.Name, this.GetType().Name + " name");
            }
            this.productsList.Remove(cosmetics);
        }

        public string Print()
        {
            //Products in category should be sorted by brand in ascending order and then by price in descending order.
            var sortedProducts = productsList.OrderBy(b => b.Brand).ThenByDescending(p => p.Price).ToList();
            var categoryPrint = new StringBuilder();
            categoryPrint.AppendFormat(" {0} category – {1} {2} in total)", this.Name, productsList.Count, productsList.Count == 1 ? "product" : "products");

            foreach (var product in sortedProducts)
            {
                categoryPrint.AppendFormat("{0} - {1}", product.Brand, product.Name);
                categoryPrint.AppendFormat("Price: ${0}", product.Price);
                categoryPrint.AppendFormat("For gender: {}", product.Gender);

                if (product is Toothpaste)
                {

                    (product as Toothpaste).Print();
                }
                if (product is Shampoo)
                {
                    (product as Shampoo).Print();
                }

            }

            return categoryPrint.ToString();
        }
    }
}
