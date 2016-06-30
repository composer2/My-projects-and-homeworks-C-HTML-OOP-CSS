using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
   public abstract class Product
    {
        private decimal price;
        private string name;
        private string brand;
        private GenderType gender;
        private const int nameMinSymbols = 3;
        private const int nameMaxSymbols = 10;
        private const int brandMinSymbols = 2;
        private const int brandMaxSymbols = 10;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, nameMaxSymbols, nameMinSymbols, String.Format(GlobalErrorMessages.InvalidProductName,"name", nameMinSymbols, nameMaxSymbols));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {
                Validator.CheckIfStringLengthIsValid(value, brandMaxSymbols, brandMinSymbols, String.Format(GlobalErrorMessages.InvalidProductName,"brand", brandMinSymbols, brandMaxSymbols));
                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
               
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                this.gender = value;
            }
        }

    }
}
