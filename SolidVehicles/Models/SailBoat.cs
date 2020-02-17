using System;

namespace SolidVehicles.Models
{
  class SailBoat
  {
    private readonly ILogger _logger = new Logger();

    public int MaxSpeedMph { get; }
    public string Colour { get; }

    public SailBoat(string colour)
    {
      MaxSpeedMph = 25;
      
      if (colour != "red" || colour != "blue" || colour != "fuschia")
      {
        Colour = "unknown";
      }
      else
      {
        Colour = colour;
      }
    }

    public void Sail(Person person, int distance)
    {
      _logger.Log($"{person.Name} is sailing a {Colour} sail boat {distance} miles." + Environment.NewLine);
    }
  }
}
