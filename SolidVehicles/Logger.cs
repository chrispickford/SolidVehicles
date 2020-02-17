using System;
namespace SolidVehicles
{
  class Logger : ILogger
  {
    public void Log(string log)
    {
      Console.WriteLine(log);
    }

    public void LogNewAndImproved(string log)
    {
      throw new NotImplementedException();
    }
  }
}
