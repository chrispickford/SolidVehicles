using System;

namespace SolidVehicles.Models
{
  class Motorbike
  {
    private readonly ILogger _logger = new Logger();

    public int MaxSpeedMph { get; set; }
    public int Wheels { get; }

    public Motorbike()
    {
      MaxSpeedMph = 150;
      Wheels = 2;
    }

    public void Drive(Person person, int distance)
    {
      _logger.Log($"{person.Name} is driving a {Wheels} wheeled motorbike {distance} miles." + Environment.NewLine);
    }
  }
}
