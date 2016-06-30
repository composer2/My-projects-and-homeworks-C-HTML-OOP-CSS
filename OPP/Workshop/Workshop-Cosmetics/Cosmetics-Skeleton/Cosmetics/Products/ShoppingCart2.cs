using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class ShoppingCart2 : IShoppingCart
    {

        public ShoppingCart2(List<IProduct> productsList)
        {
            this.ProductsList = productsList;
        }

        public ShoppingCart2()
        {
        }

        public ICollection<IProduct> ProductsList
        {
            get { return new List<IProduct>(this.ProductsList); }
            set { this.ProductsList = value; }
        }

        public void AddProducts(IProduct cosmetics)
        {
            this.ProductsList.Add(cosmetics);
        }


        public void RemoveProducts(IProduct cosmetics)
        {
            this.ProductsList.Remove(cosmetics);
        }

        public void CalculateTotalPrice()
        {
            var totalPrice = 0.0M;
            foreach (var product in ProductsList)
            {
                if (product is Toothpaste)
                {

                    totalPrice += product.Price;

                }
                if (product is Shampoo)
                {
                    totalPrice += product.Price * (product as Shampoo).Milliliters;
                }

            }
            Console.WriteLine(totalPrice);
        }
    }
}
