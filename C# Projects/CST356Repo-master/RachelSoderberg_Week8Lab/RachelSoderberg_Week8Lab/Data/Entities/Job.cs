using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using RachelSoderberg_Week8Lab.Models;

namespace RachelSoderberg_Lab2.Data.Entities
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string JobName { get; set; }
        public string CompanyName { get; set; }
        public int Years { get; set; }
        public int Salary { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}