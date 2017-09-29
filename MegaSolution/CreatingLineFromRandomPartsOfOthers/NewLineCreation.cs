using System;

namespace CreatingLineFromRandomPartsOfOthers
{
  class NewLineCreator
  {
    public string CreateNewLine(string[] line)
    {
      int position, length;
      Random rand = new Random();
      position = rand.Next(line[1].Length - 1);
      length = rand.Next(1, line[1].Length - position);
      LineCutter lineCutter = new LineCutter();
      char[] lineIn = lineCutter.CutLineN2(line[1], position, length);
      position = rand.Next(line[0].Length - 1);
      length = rand.Next(1, line[0].Length - position);
      string resultLine = String.Empty;
      if (position != 0)
      {
        char[] beginning = lineCutter.CutLineN1Beginning(line[0], position);
        for (int i = 0; i < beginning.Length; i++)
        {
          resultLine += beginning[i];
        }
      }
      for (int i = 0; i < lineIn.Length; i++)
      {
        resultLine += lineIn[i];
      }
      if (position != (line[0].Length - 1))
      {
        char[] ending = lineCutter.CutLineN1Ending(line[0], position, length);
        for (int i = 0; i < ending.Length; i++)
        {
          resultLine += ending[i];
        }
      }
      return resultLine;
    }
  }
}