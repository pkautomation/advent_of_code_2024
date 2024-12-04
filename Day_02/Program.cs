

using Shared;


bool AreDecreasing(string input, int maxDiff)
{
    var numbers = Array.ConvertAll(input.Split(' ').ToArray(), int.Parse).ToList();
    int previousVal = numbers[0];
    int failureAmount = 0;

    for (int i = 1; i < numbers.Count; i++)
    {

        if (numbers[i] >= previousVal)
        {
            failureAmount++;
            numbers.RemoveAt(i - 1);
            previousVal = numbers[i];
            continue;
        }
        if (Math.Abs(numbers[i] - previousVal) > maxDiff)
        {
            failureAmount++;
            numbers.RemoveAt(i - 1);
            previousVal = numbers[i];
            continue;
        }

        previousVal = numbers[i];
    }

    return failureAmount <= 1;
}

bool AreIncreasing(string input, int maxDiff)
{
    var numbers = Array.ConvertAll(input.Split(' ').ToArray(), int.Parse).ToList();
    int previousVal = numbers[0];
    int failureAmount = 0;

    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] <= previousVal)
        {
            failureAmount++;
            numbers.RemoveAt(i - 1);
            previousVal = numbers[i - 1];
            continue;
        }
        if (Math.Abs(numbers[i] - previousVal) > maxDiff) {
            failureAmount++;
            numbers.RemoveAt(i);
            previousVal = numbers[i - 1];
            continue;
        }

        previousVal = numbers[i];
    }

    return failureAmount <= 1;
}

var puzzleLines = FileReader.ReadFile("puzzle_02.txt");
int finalScore = 0;
foreach (var line in puzzleLines)
{
    if (AreIncreasing(line, 3) || AreDecreasing(line, 3))
    {
        finalScore++;
    }
}

Console.WriteLine(finalScore);
;