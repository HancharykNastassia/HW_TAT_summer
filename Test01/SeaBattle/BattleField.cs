using System;
using System.Collections.Generic;

namespace SeaBattle
{
  public class BattleField
  {
    List<Ship> ships;
    List<Ship> deadShips;
    Coordinates shoot;
    List<Coordinates> checkedCoordinates;

    public List<Ship> Ships
    {
      get
      {
        return ships;
      }
    }

    public List<Ship> DeadShips
    {
      get
      {
        return deadShips;
      }
    }

    public Coordinates Shoot
    {
      set
      {
        shoot.x = value.x;
        shoot.y = value.y;
      }
      get
      {
        return shoot;
      }
    }

    public List<Coordinates> CheckedCoordinates
    {
      get
      {
        return checkedCoordinates;
      }
    }

    public BattleField(Ship[] shipsArray)
    {
      foreach (var ship in shipsArray)
      {
        ships.Add(ship);
      }
    }

    public void Play()
    {
      checkedCoordinates.Add(shoot);
      Ship killedShip = new Ship(shoot);
      if (ships.Contains(killedShip))
      {
        deadShips.Add(killedShip);
        ships.Remove(killedShip);
      }
    }
  }
}