using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT1
{
    public class UserService
    {
        private List<User> Users;

        public UserService()
        {
            Users = new List<User>();
            EnsureAdminExists();
            Add("mavlonbekcoding@gmail.com", "Mavlonbek0405");
            Add("mashxurbek77gmail.com", "dadajonim1");
        }

        private void EnsureAdminExists()
        {
            if (!Users.Exists(u => u.IsAdmin))
            {
                User admin = new User
                {
                    Id = 1,
                    EmailAddress = "admin@example.com",
                    Password = "adminpassword",
                    IsAdmin = true
                };
                Users.Add(admin);
            }
        }

        public void Add(string emailAddress, string password)
        {
            // Validate the user and add to the collection
            User newUser = new User
            {
                Id = Users.Count + 1,
                EmailAddress = emailAddress,
                Password = password,
                IsAdmin = false
            };
            Users.Add(newUser);
        }

        public List<User> GetUsers()
        {
            return Users;
        }
    }
}
