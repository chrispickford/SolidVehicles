using System;

namespace SolidVehicles.Models
{
  class Car
  {
    private readonly Logger _logger = new Logger();

    public int MaxSpeedMph { get; set; }
    public int Wheels { get; }

    public Car()
    {
      MaxSpeedMph = 100;
      Wheels = 4;
    }

    public void Drive(Person person, int distance)
    {
      _logger.Log($"{person.Name} is driving a {Wheels} wheeled car {distance} miles." + Environment.NewLine);
    }
  }
}
