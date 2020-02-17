using System;
using System.Collections.Generic;
using System.Globalization;

namespace SolidVehicles.Models
{
  public class Trip
  {
    private readonly ILogger _logger = new Logger();

    private readonly List<string> _locations = new List<string>();
    private TimeSpan _duration = new TimeSpan(0);

    public void AddLocation(string location, int distanceMiles, int speedMph)
    {
      _locations.Add(location);
      TimeSpan duration = TimeSpan.FromSeconds(3600d * distanceMiles / speedMph);
      _duration = _duration.Add(duration);
    }

    public void PrintLocations()
    {
      _logger.Log("Locations:");
      foreach (string location in _locations)
      {
        _logger.Log(location);
      }
      _logger.Log(null);
    }

    public void PrintTotalDuration()
    {
      _logger.Log("Duration: " + _duration.ToString(@"h\:mm\:ss", CultureInfo.CurrentCulture) + Environment.NewLine);
    }
  }
}
