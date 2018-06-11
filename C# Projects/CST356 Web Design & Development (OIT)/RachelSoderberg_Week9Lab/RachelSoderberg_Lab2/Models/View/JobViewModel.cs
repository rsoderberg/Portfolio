using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RachelSoderberg_Lab2.Models.View
{
    public class JobViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Job Name")]
        public string JobName { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Years With Company")]
        public int Years { get; set; }

        [Required]
        [Display(Name = "Salary")]
        public int Salary { get; set; }

        public int TotalIncome { get; set; }
        public int UserId { get; set; }
    }
}