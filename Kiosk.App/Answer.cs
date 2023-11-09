using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Answer<T> {
    private Dictionary<String, T> answer;

    public Dictionary<String, T> GetAnswer()
    {
        return answer;
    }




    public void SetAnswer(Dictionary<String, T> input)
    {
        var answer = input;
    }

}