﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CHUSHKA.Data.EnumRoles;

namespace CHUSHKA.Data
{
  
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public  RoleType Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; } //skopchavame orders kum dr tablici
    }
}
