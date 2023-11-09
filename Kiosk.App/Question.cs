using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Kiosk.App;

class Question<T> {
    private String questionDescription; 
    private readonly QuestionType questionType;
    private List<T> possibleAnswers; 
    private Answer<T> answer; 
    


    public String QuestionDescription { 
        get{
            return questionDescription;
        }
         set{
            questionDescription = "dumyy question";
         }
    }

    public List<T> GetPossibleAnswers()
    {
        return possibleAnswers;
    }




    public void SetPossibleAnswers(T input)
    {
        var possibleAnswers = input;
    }



    public void Run() {
        Console.WriteLine("Ask question");
    }
}