using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RachelSoderberg_Lab2.Models.View
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Years in School")]
        public int YearsInSchool { get; set; }

        [Required]
        [Display(Name = "Favorite Pizza Topping")]
        public string FavoritePizzaTopping { get; set; }
    }
}