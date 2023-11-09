using Kiosk.App;

class Parser{


    public List<Question<String>> getAllTheQuestion(){

        List< Question<String>> questionList = new List< Question<String>>();

        Question<String> firstQuestion = new Question<string>();
        firstQuestion.QuestionDescription = "Are you a software Eingineer? ";
        var questionOneOptions = new List<string> {"Yes", "No"};
        //firstQuestion.SetPossibleAnswers(questionOneOptions);
        questionList.Add(firstQuestion);

        Question<String> secondQuestion = new Question<string>();
        secondQuestion.QuestionDescription = "What is your Age?";
        questionList.Add(secondQuestion);

        Question<String> thirdQuestion = new Question<string>();
        thirdQuestion.QuestionDescription = "What is your favourite food?";
        var questionThreeOptions = new List<string> {"Rice", "Burger"};
        //thirdQuestion.SetPossibleAnswers(questionThreeOptions);
        questionList.Add(thirdQuestion);

       


        return questionList;

    }
}