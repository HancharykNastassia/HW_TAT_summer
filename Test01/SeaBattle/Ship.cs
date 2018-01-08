using System;

namespace SeaBattle
{
  public class Ship
  {
    Coordinates position;
    public Coordinates Position
    {
      get;
    }
    
    public Ship (Coordinates coordinates)
    {
      position = coordinates;
    }
  }
}
