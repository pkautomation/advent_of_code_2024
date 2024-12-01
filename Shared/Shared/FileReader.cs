namespace Shared;

public class FileReader
{
    public static List<string> ReadFile(string fileName)
    {
        var projectName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
        string[] lines = File.ReadAllLines($"Assets/{fileName}");
        var values = new List<string>();

        foreach (var line in lines)
        {
            values.Add(line);
        }

        return values;
    }
}