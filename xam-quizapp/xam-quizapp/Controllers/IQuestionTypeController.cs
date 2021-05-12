using System.Collections.Generic;

namespace quizapp.Controllers
    //it displays list of questions....
{

    public interface IQuestionTypeController
    {
        List<string> GetQuestionTypeOptions();
    }
}
