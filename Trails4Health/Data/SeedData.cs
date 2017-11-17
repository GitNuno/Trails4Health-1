using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trails4Health.Models{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider serviceProvider) {
            Trails4HealthDbContext dbContext = (Trails4HealthDbContext)serviceProvider.GetService(typeof(Trails4HealthDbContext));

            if (!dbContext.Users.Any()) {
                EnsureUsersPopulated(dbContext);
            }
            dbContext.SaveChanges();
        }

        private static void EnsureUsersPopulated(Trails4HealthDbContext dbContext)
        {
            dbContext.Users.AddRange(
                new User {Username = "admin", Password = "admin123", EMail = "admin@out.com"}
           
           );
        }
    }
}
