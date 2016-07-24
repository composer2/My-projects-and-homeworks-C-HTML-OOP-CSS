namespace Dealership.Models
{
    using System.Text;

    using Dealership.Common;
    using Dealership.Contracts;

    public class Motorcycle : Vehicle, IMotorcycle, IPriceable, ICommentable
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get { return this.category; }
          protected  set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxCategoryLength, Constants.MinCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }
        public override string ToString()
        {
            var baseString = base.ToString();
            var result = new StringBuilder();

            result.Append(baseString);
            result.Append(string.Format("Category: {0}", this.category));
            return result.ToString();
        }
    }
}
