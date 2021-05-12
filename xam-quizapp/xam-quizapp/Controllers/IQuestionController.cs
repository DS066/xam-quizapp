using quizapp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace quizapp.Controllers
{
    public interface IQuestionController
        //it shows task,list and quiz question....
    {
        Task<List<QuizQuestion>> GetQuizQuestions(string category, string difficulty, string questionType);
    }
}
