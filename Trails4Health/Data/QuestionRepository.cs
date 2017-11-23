using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trails4Health.Models
{
    public class QuestionRepository : IQuestionRepository{
        private Trails4HealthDbContext dbContext;

        public QuestionRepository(Trails4HealthDbContext dbContext){
            this.dbContext = dbContext;
        }

        public IEnumerable<Question> Questions => dbContext.Question;
    }
}
