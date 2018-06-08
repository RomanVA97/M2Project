using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2PL.Models
{
    public class UserViewModel:IdentityUser
    {
        public string Login { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
