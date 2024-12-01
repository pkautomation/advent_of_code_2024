using Shared;
int GetSmallest(string number)
{
    int maxValue = 0;

    foreach (var digit in number)
    {
        int value = int.Parse(digit.ToString());
        if (maxValue < value) maxValue = value;
    }

    return maxValue;
}

int GetDiff(int num1, int num2)
{
    return Math.Abs(num1 - num2);
}

int CalculatePresenceAmount(List<int> numbers, int value)
{
    int amount = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] == value) amount++;
        if (numbers[i] > value) return amount;
    }
    return amount;
}
var puzzleLines = FileReader.ReadFile("puzzle_01.txt");
var globalScore = 0;

var firstList = new List<int>();
var secondList = new List<int>();

foreach (var line in puzzleLines)
{
    firstList.Add(int.Parse(line.Split(" ").First()));
    secondList.Add(int.Parse(line.Split(" ").Last()));
}

firstList.Sort();
secondList.Sort();

for (int i = 0; i < firstList.Count; i++)
{
    globalScore += firstList[i] * CalculatePresenceAmount(secondList, firstList[i]);
}


Console.WriteLine(globalScore);