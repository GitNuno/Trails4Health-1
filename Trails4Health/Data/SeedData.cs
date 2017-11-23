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
            dbContext.Question.AddRange(
                new Question {QuestionID = 1, Query ="Rate the Trail" ,QuestionDate="24.11.2017"},
                new Question {QuestionID = 2, Query ="What is your name",QuestionDate="23.11.2017" },
                new Question {QuestionID = 3, Query ="What is yoru surname",QuestionDate="24.11.2017"}
                );
        }
    }
}