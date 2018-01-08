using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeaBattle;

namespace SeaBattleTest
{
  [TestClass]
  public class SeaBattleTest
  {
    [TestMethod]
    public void TestPlay1()
    {
      Ship[] ships = new Ship[3];
      Coordinates[] shoots = new Coordinates[3];
      shoots[0].x = 'a';
      shoots[0].y = 1;
      ships[0] = new Ship(shoots[0]);
      shoots[1].x = 'b';
      shoots[1].y = 9;
      ships[1] = new Ship(shoots[1]);
      shoots[2].x = 'j';
      shoots[2].y = 6;
      ships[2] = new Ship(shoots[2]);
      BattleField battleField = new BattleField(ships);
      //Coordinates shoots = new Coordinates();
      foreach (Coordinates shoot in shoots)
      {
        battleField.Shoot = shoot;
        battleField.Play();
      }
      Assert.AreEqual(0, battleField.Ships.Capacity);
    }
  }
}
