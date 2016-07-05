using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company()
        {
        }

        public Company(string name, string registrationNumber)
        {
            this.furnitures = new List<IFurniture>();
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or null");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            protected set
            {
                if (value == null || value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols");
                }
                if (!this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentException("Registration number must contains only digits");
                }
                this.registrationNumber = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber, this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no", this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            //TODO foreach furnitures
            foreach (var item in this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public IFurniture Find(string model)
        {

            foreach (var furnitureInCollection in this.furnitures)
            {
                if (string.Compare(furnitureInCollection.Model, model, true) == 0)
                {
                    return furnitureInCollection;
                }
            }
            return null;
            //return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        private bool ContainsOnlyDigits(string str)
        {
            foreach (var ch in str)
            {
                if (ch < '0' || ch > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
