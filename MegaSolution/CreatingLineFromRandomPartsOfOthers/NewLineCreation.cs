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
      char[] lineIn = new char [length];
      Array.Copy(line[1].ToCharArray(), position, lineIn, 0, length);
      string middlePart = new string(lineIn);
      position = rand.Next(line[0].Length - 1);
      length = rand.Next(1, line[0].Length - position);
      string resultLine = String.Empty;
      if (position != 0)
      {
        char[] beginning = new char [position];
        Array.Copy(line[0].ToCharArray(), beginning, position);
        string beginSubLine = new string(beginning);
        resultLine += beginSubLine;
      }
      resultLine += middlePart;
      if (position != (line[0].Length - 1))
      {
        char[] ending = new char[line[0].Length - position - length];
        Array.Copy(line[0].ToCharArray(), position + length, ending, 0, line[0].Length - position - length);
        string endSubLine = new string(ending);
      }
      return resultLine;
    }
  }
}