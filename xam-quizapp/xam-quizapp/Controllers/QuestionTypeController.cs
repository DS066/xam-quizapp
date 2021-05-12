using System.Collections.Generic;

namespace quizapp.Controllers
{
    public class QuestionTypeController : IQuestionTypeController
    {
        public QuestionTypeController()
        {

        }
        // it gives the option to choose in multiple or true false question....
        public List<string> GetQuestionTypeOptions()
        {
            var questionTypeList = new List<string>();
            questionTypeList.Add("Multiple Choice");
            questionTypeList.Add("True or False");
            return questionTypeList;
        }
    }
}
