﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }

    }
}
