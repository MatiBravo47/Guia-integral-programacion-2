﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User() { }
        public User(string name, string email) 
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
