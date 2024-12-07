using Shared;
using System.Text.RegularExpressions;

var puzzleLines = FileReader.ReadFile("puzzle_03.txt");

string myInput = @"mul[(](\d+),(\d+)[)]";

var globalScore = 0;

foreach (var item in puzzleLines)
{
    var matches = Regex.Matches(item, myInput);

    foreach (Match match in matches)
    {
        int a = int.Parse(match.Groups[1].Value);
        int b = int.Parse(match.Groups[2].Value);

        globalScore += a * b;

    }
}

Console.WriteLine(globalScore);