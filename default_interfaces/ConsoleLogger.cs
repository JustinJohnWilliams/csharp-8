using System;

public class ConsoleLogger : ILogger
{
    public void LogException(Exception exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(exception);
        Console.ResetColor();
    }
}
