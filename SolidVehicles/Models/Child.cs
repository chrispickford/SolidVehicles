using System;

namespace SolidVehicles.Models
{
  class Child : Person
  {
    private readonly int _age;

    public Child(string name, int age) : base(name)
    {
      _logger = new NewLogger();
      _age = age;
    }

    public override void Travel(string vehicle, string location, int distance, string boatColour)
    {
      if (vehicle.ToUpper() == "UNICYCLE")
      {
        throw new InvalidOperationException("Children are not allowed on unicycles.");
      }

      base.Travel(vehicle, location, distance, boatColour);
    }

    public int GetAge()
    {
      return _age;
    }
  }
}
