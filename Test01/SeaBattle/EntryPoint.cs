using System;
using System.Collections.Generic;

namespace SeaBattle
{
  class EntryPoint
  {
    const string INSTRUCTIONS = "Please enter the coordinates";
    readonly static char a = 'a';
    readonly static char j = 'j';
    const int inputLength = 2;
    const int fildSideLength = 10;

    static void Main(string[] args)
    {
      int quantityOfShips = new Random().Next(1, 25);
      Ship[] ships = new Ship[quantityOfShips];
      List<Coordinates> forbiddenCoordinates = new List<Coordinates>();
        foreach(Ship ship in ships)
        {
          Coordinates coordinates = new Coordinates();
          bool areForbiddenCoordinates = false;
          do
          {
            int xCoordinate = new Random().Next(0, 9);
            coordinates.x = Convert.ToChar(xCoordinate + a);
            coordinates.y = new Random().Next(0, 9);
            areForbiddenCoordinates = forbiddenCoordinates.Contains(coordinates);
          } while (areForbiddenCoordinates);
          forbiddenCoordinates.Add(coordinates);
          Coordinates nearbyCoordinates = new Coordinates();
          nearbyCoordinates.x = Convert.ToChar(coordinates.x + 1);
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.y = coordinates.y + 1;
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.y = coordinates.y - 1;
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.x = coordinates.x;
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.y = coordinates.y + 1;
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.x = Convert.ToChar(coordinates.x - 1);
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.y = coordinates.y;
          forbiddenCoordinates.Add(nearbyCoordinates);
          nearbyCoordinates.y = coordinates.y - 1;
          forbiddenCoordinates.Add(nearbyCoordinates);
        }
        BattleField battleField = new BattleField(ships);
      while (battleField.Ships.Capacity > 0)
      {
        string input = string.Empty;
        Coordinates shootCoordinates = new Coordinates();
        bool invalidInput = false;
        do
        {
          try
          {
            Console.WriteLine(INSTRUCTIONS);
            input = Console.ReadLine();
            invalidInput = (input.Length != inputLength) || (input.ToLower()[0] < a || input.ToLower()[0] > j)
                            || (input[1] < 0 && input[1] > (fildSideLength - 1));
            shootCoordinates.x = input[0];
            shootCoordinates.y = Convert.ToInt32(input[1]);
          }
          catch
          {
            invalidInput = true;
          }
        } while (invalidInput);
        battleField.Shoot = shootCoordinates;
        battleField.Play();
      }
      Console.WriteLine("Number of dead ships : " + battleField.DeadShips.Capacity);
      Console.WriteLine("Number of shoots : " + battleField.CheckedCoordinates.Capacity);
    }
  }
}
