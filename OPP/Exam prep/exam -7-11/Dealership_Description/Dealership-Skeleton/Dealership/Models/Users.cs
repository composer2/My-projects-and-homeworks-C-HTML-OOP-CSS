namespace Dealership.Models
{
    using Dealership.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Dealership.Common.Enums;
    using Dealership.Common;

    public class Users : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private string username;
        private IList<IVehicle> vehicles;
        private IList<IComment> comments;


        public Users(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.vehicles = new List<IVehicle>();
            this.comments = new List<IComment>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxNameLength, Constants.MinNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
                this.firstName = value;
            }

        }

        public string LastName
        {
            get { return this.lastName; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxNameLength, Constants.MinNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxPasswordLength, Constants.MinPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.StringMustBeBetweenMinAndMax,"Password",Constants.MinPasswordLength,Constants.MaxPasswordLength));
                this.password = value;
            }

        }

        public Role Role
        {
            get { return this.role; }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                this.role = value;
            }
        }


        public string Username
        {
            get { return this.username; }
            protected set
            {
                Validator.ValidateNull(value, string.Format(Constants.InputCannotBeNull));
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxNameLength, Constants.MinNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidUserName));
                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get { return this.vehicles; }
            set
            {
                
                this.vehicles = value;
            }

        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            this.comments.Add(commentToAdd);
            this.vehicles.Add(vehicleToAddComment);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (!username.Equals(username))
            {

            }
            this.comments.Remove(commentToRemove);
            this.vehicles.Remove(vehicleToRemoveComment);
        }
        public void AddVehicle(IVehicle vehicle)
        {
            //Adding a vehicle
            //If the user is admin he cannot add a vehicle
            //If the user is not VIP he cannot add more than 5 vehicles
            if (Role.Equals("Admin"))
            {
                throw new ArgumentException(string.Format(Constants.AdminCannotAddVehicles));
            }
            if ( Role.Equals("Normal") && vehicles.Count > 5)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }
            this.vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }

        public string PrintVehicles()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("Username: {0}, FullName: {1} {2}, Role: {3}", this.username, this.firstName, this.lastName, this.role));
            result.Append(string.Format("--USER {0}--", this.username));
            //var countOfVehicles = 1;

            //foreach (var item in vehicles)
            //{
            //    result.AppendLine(string.Format("{0}. {1}:", countOfVehicles, this.GetType().Name));
            //    Console.WriteLine(item.ToString());
            //    result.AppendLine(string.Format("--{0}--", comments.Count > 0 ? "COMMENTS" : "NO COMMENTS"));
            //    //if (comments.Count > 0)
            //    //{
            //    //    foreach (var comment in comments)
            //    //    {
            //    //        result.AppendLine(string.Format("----------"));
            //    //        result.AppendLine(string.Format("{0}", this.comments));
            //    //        result.AppendLine(string.Format("User: {0}", this.username));
            //    //        result.AppendLine(string.Format("----------"));
            //    //    }
            //    //    result.AppendLine(string.Format("--COMMENTS--"));
            //    //}
            //    countOfVehicles++;
            //}
            return result.ToString().TrimEnd();
        }


    }
}
