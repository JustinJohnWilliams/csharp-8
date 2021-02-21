using System;
using System.IO;

public class FileLogger : ILogger
{
    private string _fileName;

    public FileLogger() : this("output.txt") { }

    public FileLogger(string fileName)
    {
        _fileName = fileName;
    }

    public void LogMessage(string message)
    {
        File.WriteAllText(_fileName, message);
    }

    public void LogException(Exception exception)
    {
        File.WriteAllLines(_fileName, new[] {
            "--BEGIN EXCEPTION--",
            $"{exception}",
            "--END EXCEPTION--"
        });
    }
}
