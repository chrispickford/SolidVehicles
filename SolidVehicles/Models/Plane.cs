using System;

namespace SolidVehicles.Models
{
  class Plane
  {
    private readonly ILogger _logger = new Logger();

    public int MaxSpeedMph { get; }
    public int Wings { get; }

    public Plane()
    {
      MaxSpeedMph = 400;
      Wings = 2;
    }

    public void Fly(Person person, int distance)
    {
      _logger.Log($"{person.Name} is flying a {Wings} winged plane {distance} miles." + Environment.NewLine);
    }
  }
}
