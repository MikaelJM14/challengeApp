using ChallengeApp;

Console.WriteLine("Wjtamy w programie XYZ do oceny Pracownikow");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("podaj kolejnom ocene pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



//employee.AddGrade(input);
