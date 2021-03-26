using System.Collections.Generic;
using System.Linq;
using Shop.Models;

namespace Shop.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Username = "oauth.api", Password = "t3-Q42456TyrKR]-Mr843" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}