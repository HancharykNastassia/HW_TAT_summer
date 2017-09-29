using System;

namespace CreatingLineFromRandomPartsOfOthers
{
  class LineCutter
  {
    public char[] CutLineN1Beginning (string line, int marker)
    {
      char[] lineOut = new char[marker + 1];
      for (int i = 0; i < marker + 1; i++)
      {
        lineOut[i] = line[i];
      }
      return lineOut;
    }

    public char[] CutLineN1Ending (string line, int position, int length)
    {
      char[] lineOut = new char[line.Length - position - length];
      for (int i = position + length; i < line.Length; i++)
      {
        lineOut[i - (position + length)] = line[i];
      }
      return lineOut;
    }

    public char[] CutLineN2 (string line, int position, int length)
    {
      char[] lineOut = new char[length];
      for (int i = position; i < position + length; i++)
      {
        lineOut[i - position] = line[i];
      }
      return lineOut;
    }
  }
}