using SolidVehicles.Models;
using System;
using System.Collections.Generic;

namespace SolidVehicles
{
  static class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("SOLID Vehicles App");
      Console.WriteLine("------------------");
      Console.WriteLine();

      var people = new List<Person>
      {
        new Person("Reginald")
        {
          CurrentLocation = "Bristol"
        },
        new Child("Simon", 11)
        {
          CurrentLocation = "Stockholm"
        }
      };

      var logger = new NewLogger();

      foreach (var person in people)
      {
        logger.LogNewAndImproved($"Travel details for {person.Name}:" + Environment.NewLine);

        if (person is Child child)
        {
          logger.LogNewAndImproved($"{child.Name} is {child.GetAge()} years old!" + Environment.NewLine);
        }

        try {
          person.Travel("Car", "London", 140, null);
          person.Travel("Plane", "Venice", 700, null);
          person.Travel("Speedboat", "Athens", 1000, "purple");
          person.Travel("Sailboat", "Beirut", 750, "blue");
          person.Travel("Unicycle", "Baghdad", 600, null);
          person.Travel("Motorbike", "Abu Dhabi", 1135, null);
          person.Travel("Plane", "Bristol", 3500, null);
        }
        catch (Exception ex)
        {
          logger.Error(ex.Message);
        }

        person.PrintItinerary();
      }

      Console.ReadKey();
    }
  }
}
