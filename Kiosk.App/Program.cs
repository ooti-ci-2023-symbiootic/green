using System.CommandLine;
using System.CommandLine.Invocation;
using Kiosk.App;

// This is an example program that shows how to handle CLI arguments
// with System.CommandLine. Feel free to throw it all away.
//
// To run this program, use the embedded Terminal, and do this:
// > cd Kiosk.App
// > dotnet run -- <command> <options>
//
// eg
// > dotnet run -- read

// Create a root command with some options
var rootCommand = new RootCommand
{
    Description = "OOTI Survey Kiosk",
    Handler = CommandHandler.Create<bool>((sayHi) =>
    {
        if (sayHi)
        {
            Console.WriteLine("hi!");
        }
        else {
            Console.WriteLine("Dotnet works!");
        }
    })
};

// just a dummy option to show how options work
rootCommand.AddOption(new Option<bool>("--say-hi", description: "Say hi"));

var read = new Command("read", "Read the survey file and display diagnostic info")
{
    Handler = CommandHandler.Create(() => new Read().Run())
};

var ask = new Command("ask", "Ask a single voter the questionnaire")
{
    //Handler = CommandHandler.Create(() => new Question(Clas).Run())
};

var survey = new Command("survey", "Ask all voters the questionnaire")
{
    Handler = CommandHandler.Create(() => new Survey().Run())
};

var results = new Command("results", "Show results on the command line")
{
    Handler = CommandHandler.Create(() => new Results().Run())
};

var report = new Command("report", "Generate report of the results")
{
    Handler = CommandHandler.Create(() => new Report().Run())
};

// NOTE: if you want a subcommand to have options, do something like this:
//
// var report = new Command("report", "Generate report of the results")
// {
//     Handler = CommandHandler.Create<bool, string>((extraPretty, output) => 
//         new Report(extraPretty, output).Run()
//     )
// };
// report.AddOption(new Option<bool>("extra-pretty"));
// report.AddOption(new Option<string>("output"));
//
// then call it like
//   dotnet run report --extra-pretty --output myfile.html

rootCommand.AddCommand(read);
rootCommand.AddCommand(ask);
rootCommand.AddCommand(survey);
rootCommand.AddCommand(results);
rootCommand.AddCommand(report);


// Parse the incoming args and invoke the handler

var parser = new Parser();
var questions = parser.getAllTheQuestion();
//var questions = Read.readQuestion();

var numQuestions = questions.Count;

var voters = new List<string>
{
    "Voter1",
    "Voter2",
    "Voter3"
};
var numVoters = voters.Count;
var voterI = 0;
while (voterI < numVoters)
{
    Console.WriteLine("Welcome to the voting Kiosk app. " + voters[voterI] + " please come forward and press enter when you are ready.");
    Console.ReadLine();
    var questionIterator = 0;
    while (questionIterator < numQuestions)
    {
        //var survey = new Survey(voters[voterI], questions[questionIterator]);
        //survey.Start();
        questionIterator += 1;
    }
    Console.WriteLine("Stop with the surveys? Y/N");
    var stopSurveys = Console.ReadLine();
    if (voterI < numVoters-1 && stopSurveys.Equals("Y", StringComparison.OrdinalIgnoreCase))
    {
        voterI = numVoters;
    }
    voterI += 1;
}
Console.WriteLine("Now producing reports for all the questions.");
// produce reports
Console.WriteLine("Thank you for using the voting Kiosk app.");

// return rootCommand.Invoke(args);