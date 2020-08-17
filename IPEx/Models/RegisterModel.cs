using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IPEx.Models
{
    public class RegisterModel
    {
        [Display(Name ="Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
    }
}