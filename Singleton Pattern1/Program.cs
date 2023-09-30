using System;

public class Logger
{
    // Private static instance variable to hold the single instance of Logger.
    private static Logger instance;

    // Private constructor to prevent instantiation from other classes.
    private Logger()
    {
    }

    // Public method to get the single instance of Logger.
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    // Public method to log a message. which shows date and time when the log message was generated
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the Logger instance.
        Logger logger = Logger.GetInstance();

        // Use the Logger to log messages.
        logger.Log("Hello There, This is my first log message!");
        logger.Log("And, this is my second log message!!");

        // Both calls to GetInstance() will return the same Logger instance.
        Logger sameLogger = Logger.GetInstance();
        Console.WriteLine("Are we both logger called from 'Main' Method? " + (logger == sameLogger));
    }
}
