using System;
using System.IO;

public class ReportSaver
{
    public void SaveToFile(string content, string fileName)
    {
        File.WriteAllText(fileName, content);
        Console.WriteLine("Report saved to: " + fileName);
    }
}
