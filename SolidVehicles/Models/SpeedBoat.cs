using System;

namespace SolidVehicles.Models
{
  class SpeedBoat
  {
    private readonly ILogger _logger = new Logger();

    public int MaxSpeedMph { get; }
    public string Colour { get; set; }

    public SpeedBoat()
    {
      MaxSpeedMph = 60;
    }

    public void Sail(Person person, int distance)
    {
      _logger.Log($"{person.Name} is sailing a {Colour} speed boat {distance} miles." + Environment.NewLine);
    }
  }
}
