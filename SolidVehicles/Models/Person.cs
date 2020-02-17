using System;

namespace SolidVehicles.Models
{
  class Person
  {
    protected ILogger _logger = new Logger();
    protected readonly Trip _trip = new Trip();

    public string Name { get; }

    public Person(string name)
    {
      Name = name;
    }

    public string CurrentLocation { get; set; }

    public virtual void Travel(string vehicle, string location, int distance, string boatColour)
    {
      _logger.Log($"{Name} is travelling to {location} from {CurrentLocation}.");

      switch (vehicle.ToUpper())
      {
        case "CAR":
          var car = new Car();
          car.Drive(this, distance);
          _trip.AddLocation(location, distance, car.MaxSpeedMph);
          break;
        case "MOTORBIKE":
          var motorbike = new Motorbike();
          motorbike.Drive(this, distance);
          _trip.AddLocation(location, distance, motorbike.MaxSpeedMph);
          break;
        case "PLANE":
          var plane = new Plane();
          plane.Fly(this, distance);
          _trip.AddLocation(location, distance, plane.MaxSpeedMph);
          break;
        case "SAILBOAT":
          var sailBoat = new SailBoat(boatColour);
          sailBoat.Sail(this, distance);
          _trip.AddLocation(location, distance, sailBoat.MaxSpeedMph);
          break;
        case "SPEEDBOAT":
          var speedBoat = new SpeedBoat();
          speedBoat.Colour = boatColour;
          speedBoat.Sail(this, distance);
          _trip.AddLocation(location, distance, speedBoat.MaxSpeedMph);
          break;
        case "UNICYCLE":
          var unicycle = new Unicycle();
          unicycle.Ride(this, distance);
          _trip.AddLocation(location, distance, unicycle.MaxSpeedMph);
          break;
      }

      CurrentLocation = location;
    }

    public void PrintItinerary()
    {
      _trip.PrintTotalDuration();
      _trip.PrintLocations();
    }
  }
}
