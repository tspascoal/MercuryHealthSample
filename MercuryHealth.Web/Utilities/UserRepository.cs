using MercuryHealth.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MercuryHealth.Web.Utilities
{
    public class UserRepository
    {
        public UserRepository()
        {

        }

        public User GetUser(int userId)
        {
            var db = new ApplicationDbContext();
            var theUser = db.Users.FirstOrDefault(user => user.Id == userId.ToString());

            return theUser == null ? null : new User
            {
                Id = userId,
                FirstName = theUser.UserName,
                LastName = theUser.UserName
            };
        }
    }
}