using System;
using System.Collections.Generic;

namespace PathValidation
{
  public class Validator
  {
    char[] foriddenSymbols = { '*', '|', '"', '<', '>', '?', '/', ':' };
    string[] forbiddenNames = {"CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7",
                                 "COM8", "COM9", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };

    //Common method for Path validation
    public bool ValidatePath(string filePath)
    {
      if (filePath.Equals(String.Empty))
      {
        return false;
      }
      if (!filePath.Contains("\\"))
      {
        return !IsFilePathContainsForbiddenSymbols(filePath) && !IsFilePathContainsForbiddenFileName(filePath);
      }
      int backslashPositionAtLongPath = 2;
      int secondBackslashPositionAtShortPath = 1;
      string tempString = String.Empty;
      if (IsLongPath(filePath))
      {
        tempString = filePath.Substring(backslashPositionAtLongPath + 1);
      }
      else if (IsShortPath(filePath))
      {
        tempString = filePath.Substring(secondBackslashPositionAtShortPath + 1);
      }
      else
      {
        return false;
      }
      if (tempString.Equals(String.Empty) || tempString.Equals("\\"))
      {
        return true;
      }
      if (IsFilePathContainsForbiddenSymbols(tempString))
      {
        return false;
      }
      if (IsFilePathContainsForbiddenFileName(tempString))
      {
        return false;
      }
      return !IsFilePathHasWrongEndings(tempString);
    }

    //Checks if the string can be a long path
    private bool IsLongPath(string filePath)
    {
      string filePathInLowCase = filePath.ToLower();
      if ((filePathInLowCase[0] >= 'a') && (filePathInLowCase[0] <= 'z'))
      {
        if (filePathInLowCase[1] == ':')
        {
          int countBackslashes = 0;
          for (int i = 2; i < filePathInLowCase.Length; i++)
          {
            if (filePathInLowCase[i] == '\\')
            {
              countBackslashes++;
            }
            else
            {
              break;
            }
          }
          if (countBackslashes == 1)
          {
            return true;
          }
        }
      }
      return false;
    }

    //Checks if the string can be a short path
    private bool IsShortPath(string filePath)
    {
      int countBakslashes = 0;
      foreach (var symbol in filePath)
      {
        if (symbol == '\\')
        {
          countBakslashes++;
        }
        else
        {
          break;
        }
      }
      if (countBakslashes == 2)
      {
        return true;
      }
      countBakslashes = 0;
      int countDots = 0;
      foreach (var symbol in filePath)
      {
        if (symbol == '.')
        {
          countDots++;
        }
        else if ((symbol == '\\') && (countDots > 0))
        {
          countBakslashes++;
        }
        else
        {
          return false;
        }
      }
      return (((countDots == 1) || (countDots == 2)) && (countBakslashes == 1));
    }

    // Checks if the path contains forbidden symbols
    private bool IsFilePathContainsForbiddenSymbols(string filePath)
    {
      foreach (var symbol in foriddenSymbols)
      {
        if (filePath.Contains(symbol.ToString()))
        {
          return true;
        }
      }
      return false;
    }

    //Checks if the path containes reserved names
    private bool IsFilePathContainsForbiddenFileName(string filePath)
    {
      string filePathInUpperCase = filePath.ToUpper();
      string[] cutPath = CutPath(filePathInUpperCase);
      if (filePathInUpperCase.LastIndexOf('.') > filePathInUpperCase.LastIndexOf('\\'))
      {
        string[] tempPath = new string[cutPath.Length - 1];
        Array.Copy(cutPath, tempPath, tempPath.Length);
        cutPath = new string[tempPath.Length];
        Array.Copy(tempPath, cutPath, tempPath.Length);
      }
      foreach (var name in forbiddenNames)
      {
        if (filePathInUpperCase.Contains(name))
        {
          foreach (var piece in cutPath)
          {
            if (piece.Equals(name))
            {
              return true;
            }
          }
        }
      }
      return false;
    }

    // Checks if folders have dots or spaces as endings or the path ends with dot or space
    private bool IsFilePathHasWrongEndings(string filePath)
    {
      string[] cutPath = CutPath(filePath);
      if (cutPath.Length > 0)
      {
        foreach (var piece in cutPath)
        {
          if ((piece.Length > 0) && ((piece[piece.Length - 1] == ' ') || (piece[piece.Length - 1] == '.')))
          {
            return true;
          }
        }
        //return (filePath[filePath.Length - 1] == '\\');
      }
      return false;
    }

    // Method cuts the path into names of folders, file and resolution
    private string[] CutPath(string filePath)
    {
      List<string> cutPath = new List<string>();
      //int previouseBackslashIndex = 0;
      int backslashIndex = 0;
      int firstPositionOfReading = 0;
      string tempString = String.Empty;
      if (!filePath.Contains("\\") && !(filePath.Contains(".")))
      {
        cutPath.Add(filePath);
        return cutPath.ToArray();
      }
      if (filePath[0] == '\\')
      {
        firstPositionOfReading = 1;
      }
      backslashIndex = filePath.IndexOf('\\', firstPositionOfReading);
      while (backslashIndex >= 0)
      {
        tempString = filePath.Substring(firstPositionOfReading, backslashIndex - firstPositionOfReading);
        if (!tempString.Equals(".") && !tempString.Equals(".."))
        {
          cutPath.Add(tempString);
        }
        firstPositionOfReading = backslashIndex + 1;
        backslashIndex = filePath.IndexOf('\\', firstPositionOfReading);
      }
      backslashIndex = filePath.LastIndexOf('\\');
      if (backslashIndex < filePath.Length - 1)
      {
        tempString = filePath.Substring(firstPositionOfReading);
        if (tempString.Contains("."))
        {
          string temp = tempString.Substring(0, tempString.LastIndexOf('.'));
          cutPath.Add(temp);
          temp = tempString.Substring(tempString.LastIndexOf('.') + 1);
          cutPath.Add(temp);
        }
        else
        {
          cutPath.Add(tempString);
        }
      }
      return cutPath.ToArray();
    }
  }
}