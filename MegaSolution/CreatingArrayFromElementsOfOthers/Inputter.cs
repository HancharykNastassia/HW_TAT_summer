﻿using System;

namespace CreatingArrayFromElementsOfOthers
{
  class Inputter
  {
    const int MINVALUE = 2;
    const int MAXVALUE = 100;
    public double[][] GetArrays()
    {
      Random rand = new Random();
      double[][] arrays = new double[rand.Next(MINVALUE, MAXVALUE)][];
      for (int i = 0; i < arrays.Length; i++)
      {
        arrays[i] = new double[rand.Next(MAXVALUE)];
        foreach (int j in arrays[i])
        {
          arrays[i][j] = rand.NextDouble() * rand.Next(MAXVALUE);
          Console.WriteLine(arrays[i][j]);
        }
      }
      return arrays;
    }
  }
}