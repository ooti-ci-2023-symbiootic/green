using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Kiosk.App;

class Question<T> {
    private String questionDescription; 
    private QuestionType questionType;
    private List<T> possibleAnswers; 
    private Answer<T> answer; 
    


     public String GetQuestionDescription()
    {
        return questionDescription;
    }




    public void SetQuestionDescription(String questionDescription)
    {
        questionDescription = questionDescription
    }

    public List<T> GetPossibleAnswers()
    {
        return possibleAnswers;
    }




    public void SetPossibleAnswers(List<T> input)
    {
        var possibleAnswers = input;
    }

    public Answer<T> GetAnswer()
    {
        return answer;
    }




    public void SetAnswer(Answer<T> answer)
    {
        answer = answer;
    }

    public QuestionType GetQuestionType()
    {
        return questionType;
    }




    public void SetQuestionType(QuestionType questionType)
    {
        questionType = questionType;
    }




    public void Run() {
        Console.WriteLine("Ask question");
    }
}