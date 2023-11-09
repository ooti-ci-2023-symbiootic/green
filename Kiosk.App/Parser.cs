using Kiosk.App;

class Parser{


    public List<Question<String>> getAllTheQuestion(){

        List< Question<String>> questionList = new List< Question<String>>();

        Question<String> firstQuestion = new Question<string>();
        firstQuestion.QuestionDescription = "Are you a software Eingineer? ";
        firstQuestion.SetQuestionType(QuestionType.SingleAnswer);
        var questionOneOptions = new List<string> {"Yes", "No"};
        firstQuestion.SetPossibleAnswers(questionOneOptions);
        questionList.Add(firstQuestion);

        Question<String> secondQuestion = new Question<string>();
        secondQuestion.QuestionDescription = "What is your Age?";
        secondQuestion.SetQuestionType(QuestionType.Descriptional);
        questionList.Add(secondQuestion);

        Question<String> thirdQuestion = new Question<string>();
        thirdQuestion.QuestionDescription = "What is your favourite food?";
        thirdQuestion.SetQuestionType(QuestionType.SingleAnswer);
        var questionThreeOptions = new List<string> {"Rice", "Burger"};
        //thirdQuestion.SetPossibleAnswers(questionThreeOptions);
        questionList.Add(thirdQuestion);

       


        return questionList;

    }
}