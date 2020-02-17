using System;
namespace SolidVehicles
{
  class NewLogger : ILogger
  {
    public void Log(string log)
    {
      Console.WriteLine(log);
    }

    public void LogNewAndImproved(string log)
    {
      Console.BackgroundColor = ConsoleColor.Yellow;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine(log);
      Console.ResetColor();
    }

    public void Error(string error)
    {
      Console.BackgroundColor = ConsoleColor.Red;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(error);
      Console.ResetColor();
    }
  }
}
