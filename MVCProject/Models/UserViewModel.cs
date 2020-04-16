using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class UserViewModel // traktujemy jako tabele - podejscie code first
    {
        public int id { get; set; } //jako kolumny w tabeli
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public bool Gender { get; set; }
        
    }
}
