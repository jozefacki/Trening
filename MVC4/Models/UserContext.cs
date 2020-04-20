using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace MVC4.Models
{
    public class UserContext : DbContext
    {
        public DbSet<UserViewModel> Users { get; set; }

    }
}