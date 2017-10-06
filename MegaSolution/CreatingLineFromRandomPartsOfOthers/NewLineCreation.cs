using System;

namespace CreatingLineFromRandomPartsOfOthers
{
  class NewLineCreator
  {
    public string CreateNewLine(string[] lines)
    {
      string resultLine = String.Empty;
      string middlePart = String.Empty;
      int position, length;
      if (lines[1].Length > 0)
      {
        position = new Random().Next(lines[1].Length - 1);
        length = new Random().Next(1, lines[1].Length - position);
        char[] lineIn = new char[length];
        Array.Copy(lines[1].ToCharArray(), position, lineIn, 0, length);
        middlePart = new string(lineIn);
      }
      if (lines[0].Length > 0)
      {
        position = new Random().Next(lines[0].Length - 1);
        length = new Random().Next(1, lines[0].Length - position);
        if (position != 0)
        {
          char[] beginning = new char[position];
          Array.Copy(lines[0].ToCharArray(), beginning, position);
          string beginSubLine = new string(beginning);
          resultLine += beginSubLine;
        }
        resultLine += middlePart;
        if (position != (lines[0].Length - 1))
        {
          char[] ending = new char[lines[0].Length - position - length];
          Array.Copy(lines[0].ToCharArray(), position + length, ending, 0, lines[0].Length - position - length);
          string endSubLine = new string(ending);
          resultLine += endSubLine;
        }
      }
      return resultLine;
    }
  }
}