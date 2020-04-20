using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC4.Models
{
    public class UserContext : DbContext
    {
        public DbSet <UserViewModel> Users { get; set; }

    }
}