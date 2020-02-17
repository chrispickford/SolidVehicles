using System;

namespace SolidVehicles.Models
{
  class Unicycle
  {
    private readonly ILogger _logger = new NewLogger();

    public int MaxSpeedMph { get; }
    public int Wheels { get; }

    public Unicycle()
    {
      MaxSpeedMph = 35;
      Wheels = 1;
    }

    public void Ride(Person person, int distance)
    {
      _logger.LogNewAndImproved($"{person.Name} is riding a {Wheels} wheeled unicycle {distance} miles." + Environment.NewLine);
    }
  }
}
