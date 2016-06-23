using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    internal class UserProfile
    {
        public int UserId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public UserProfile(int id, string fisrt, string last)
        {
            this.FirstName = fisrt;
            this.LastName = last;
            this.UserId = id;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, First name: {1}, Last name: {2}", this.UserId, this.FirstName, this.LastName);
        }
    }
}
