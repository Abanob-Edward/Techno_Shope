﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Role
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<UserRole> userRoles { get; set;}
    }
}
