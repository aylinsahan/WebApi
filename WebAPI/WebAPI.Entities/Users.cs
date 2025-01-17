﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAPI.Entities
{
   public class Users : BaseEntity<int>
    {
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string FirtName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(20)]
        public string PasswordHash { get; set; }
     
    }
}
