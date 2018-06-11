using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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

        public int UserId { get; set; }
        public User User { get; set; }
    }
}