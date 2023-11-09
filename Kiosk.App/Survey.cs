using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Survey {

    string voterName;
    List<Question<string>> questions = new List<Question<string>>();

    public void Run() {
        Console.WriteLine("Survey");
    }

    public void displayQuestions()
    {
        foreach(Question<string> question in questions)
        {
            Console.WriteLine(question.QuestionDescription);            
        }

    }

    public void recordAnswers()
    {

    }
}