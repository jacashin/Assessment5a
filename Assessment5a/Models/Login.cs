using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5a.Models
{
    public class Login
    {
        [ViewData]
        [Required]
        public string Name { get; set; }

        [ViewData]
        [Required]
        public string Password { get; set; }
    }
}
