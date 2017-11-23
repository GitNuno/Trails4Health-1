using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trails4Health.Models
{
    public class Trails4HealthDbContext: DbContext
    {
        public Trails4HealthDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Question> Question { get; set; }
    }
}
