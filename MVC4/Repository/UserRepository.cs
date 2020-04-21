using MVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4.Repository
{
    public class UserRepository
    {
        private UserContext db = new UserContext();


        public List <UserViewModel> GetAllUsersByFirstName()
        {
            return db.Users.ToList().FindAll(x => x.FirstName.StartsWith("K"));
        }
    }
}