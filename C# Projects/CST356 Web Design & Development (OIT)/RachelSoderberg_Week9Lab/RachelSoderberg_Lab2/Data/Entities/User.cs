using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RachelSoderberg_Lab2.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public int YearsInSchool { get; set; }
        public string FavoritePizzaTopping { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}