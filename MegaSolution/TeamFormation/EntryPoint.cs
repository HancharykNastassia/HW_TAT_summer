using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamFormation
{
  class EntryPoint
  {
    const string FILENAME = "";
    const string FOREXIT = "Press any key for exit";
    static void Main(string[] args)
    {
      try
      {
        List<Developer> listOfAvailableDevelopers = new List<Developer>();
        using (StreamReader readThreat = File.OpenText(FILENAME))
        {
          while (!readThreat.EndOfStream)
          {
            string line = readThreat.ReadLine();
            if (readThreat.EndOfStream)
            {
              break;
            }
            string[] partOfInputLine = line.Split('|');
            int productivity = Int32.Parse(partOfInputLine[1]);
            int salary = Int32.Parse(partOfInputLine[2]);
            listOfAvailableDevelopers.Add(new Developer(productivity, salary, partOfInputLine[0]));
          }
        }
        Console.WriteLine("Input the amount of money");
        int nesessaryAmount = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Input nessessary productivity");
        int nesessaryProductivity = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Choose the criteria");
        int criteriaNumber = Int32.Parse(Console.ReadLine());
        Mediator mediator = new Mediator(criteriaNumber, nesessaryAmount, nesessaryProductivity, 
                                         listOfAvailableDevelopers);
        mediator.MakeTeam();
        List<Developer> team = new List<Developer>();
        foreach (var developer in mediator.Team)
        {
          team.Add(developer);
        }
        StringBuilder output = new StringBuilder("Team: " + team.Capacity);
      }
      finally
      {
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
    }
  }
}
