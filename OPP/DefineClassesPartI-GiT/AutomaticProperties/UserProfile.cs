using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class UserProfile
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserProfile(int user, string first, string last)
        {
            this.UserId = user;
            this.FirstName = first;
            this.LastName = last;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, First name: {1}, Last Name {2}", this.UserId, this.FirstName, this.LastName);
        }
        static void Main(string[] args)
        {
            UserProfile profile = new UserProfile(777, "Boncho", "Belutov");
            Console.WriteLine(profile.ToString());

            UserProfile profile2 = new UserProfile(111, "Steve", "Jobs");
            Console.WriteLine(profile2);

        }
    }
}
