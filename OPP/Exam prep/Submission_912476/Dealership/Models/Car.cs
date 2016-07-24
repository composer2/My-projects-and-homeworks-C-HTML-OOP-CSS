namespace Dealership.Models
{
    using System.Text;

    using Dealership.Common;
    using Dealership.Contracts;

    public class Car : Vehicle, ICar, IPriceable, ICommentable
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get { return this.seats; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }
        public override string ToString()
        {
            var baseString = base.ToString();
            var result = new StringBuilder();

            result.Append(baseString);
            result.Append(string.Format("Seats: {0}",this.seats));
            return result.ToString();
        }
    }
}
