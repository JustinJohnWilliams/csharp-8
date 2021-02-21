using System;

public interface ILogger
{
    void LogMessage(string message) => Console.WriteLine(message);
    void LogException(Exception exception);
}
