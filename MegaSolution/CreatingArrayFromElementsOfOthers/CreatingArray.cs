using System;

namespace CreatingArrayFromElementsOfOthers
{
  class CreatingArray
  {
    /// <summary>
    /// Creates new array of elements wich are included in other arrays not less then two times
    /// </summary>
    /// <param name="listOfArrays">
    /// The two-dimensional array which includes arrays for searching in
    /// </param>
    /// <returns>
    /// Array made of elements wich are included in arrays not less then two times
    /// </returns>
    public double[] CreateArray (double[][] listOfArrays)
    {
      double EPSILON = 1e-9;
      double[] resultArray = new double[] { };
      for (int i = 0; i < listOfArrays.Length - 1; i++)
      {
        for (int j = 0; j < listOfArrays[i].Length; j++)
        {
          if (resultArray.Length != 0)
          {
            bool contains = false;
            foreach (int index in resultArray)
            {
              if (Math.Abs(listOfArrays[i][j] - resultArray[index]) < EPSILON)
              {
                contains = true;
                break;
              }
            }
            if (contains)
            {
              continue;
            }
          }
          for (int k = i + 1; k < listOfArrays.Length; k++)
          {
            bool gotNewMember = false;
            for (int l = 0; l < listOfArrays[k].Length; l++)
            {              
              if (Math.Abs(listOfArrays[i][j] - listOfArrays[k][l]) < EPSILON)
              {
                int resultArrayLength = resultArray.Length;
                double[] tempArray = new double[resultArrayLength];
                Array.Copy(resultArray, tempArray, resultArrayLength);
                resultArray = new double[resultArrayLength + 1];
                Array.Copy(tempArray, resultArray, resultArrayLength);
                resultArray[resultArrayLength] = listOfArrays[i][j];
                gotNewMember = true;
                break;
              }
            }
            if(gotNewMember)
            {
              break;
            }
          }
        }
      }
      return resultArray;
    }
  }
}