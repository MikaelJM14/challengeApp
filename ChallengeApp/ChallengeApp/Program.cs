using ChallengeApp;
using System;

Console.WriteLine("Wjtamy w programie XYZ do oceny Pracownikow");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "kamizelich");

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowa ocene");
}

while (true)
{
    Console.WriteLine("podaj kolejnom ocene pracownika: ");
   var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched {e.Message}");
    }

}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
