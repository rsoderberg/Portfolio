using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RachelSoderberg_Lab2.Data.Entities;

namespace RachelSoderberg_Lab2.Data
{
    public interface IDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Job> Jobs { get; set; }
    }
}
