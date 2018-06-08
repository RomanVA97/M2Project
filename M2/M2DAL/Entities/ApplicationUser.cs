using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string Login { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
