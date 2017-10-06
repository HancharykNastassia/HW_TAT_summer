using System;

namespace CreatingArrayFromElementsOfOthers
{
  class Inputter
  {
    const int MINVALUE = 2;
    const int MAXVALUE = 100;
    /// <summary>
    /// Creates array which contains from 2 to 100 arrays with not more
    /// then 100 double in range of about 0.0 to about 100.0
    /// </summary>
    /// <returns>
    /// Two-dimensional array.
    /// </returns>
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
        }
      }
      return arrays;
    }
  }
}