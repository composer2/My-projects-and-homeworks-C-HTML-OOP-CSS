namespace Dealership.Models
{
    using System.Text;

    using Dealership.Common;
    using Dealership.Contracts;

    class Truck : Vehicle, ITruck, IPriceable, ICommentable
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get { return this.weightCapacity; }
           protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
                this.weightCapacity = value;
            }
        }

        public override string ToString()
        {
            var baseString = base.ToString();
            var result = new StringBuilder();

            result.Append(baseString);
            result.Append(string.Format("Weight: {0}", this.weightCapacity));
            return result.ToString();
        }
    }
}
