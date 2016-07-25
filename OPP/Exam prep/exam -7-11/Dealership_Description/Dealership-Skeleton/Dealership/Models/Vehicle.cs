namespace Dealership.Models
{
    using Dealership.Contracts;
    using System.Collections.Generic;

    using Dealership.Common.Enums;
    using Common;
    using System.Text;
    public abstract class Vehicle : IVehicle, IPriceable, ICommentable
    {
        private string make;
        private string model;
        private decimal price;
        private int wheels;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        //TODO validation
        public IList<IComment> Comments { get; protected set; }

        public string Make
        {
            get { return this.make; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxMakeLength, Constants.MinMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxModelLength, Constants.MinMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }

        public VehicleType Type { get; protected set; }


        public int Wheels
        {
            get { return this.wheels; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels, string.Format(Constants.NumberMustBeBetweenMinAndMax, "", Constants.MinWheels, Constants.MaxWheels));
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("Make: {0}", this.make));
            result.AppendLine(string.Format("Model: {0}", this.model));
            result.AppendLine(string.Format("Wheels: {0}", this.wheels));
            result.AppendLine(string.Format("Price: ${0}", this.price));
            return result.ToString().TrimEnd();
        }
    }
}
