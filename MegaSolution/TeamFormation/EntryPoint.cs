using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamFormation
{
  class EntryPoint
  {
    const string FILENAME = @"DevelopersList.txt";
    const string FOREXIT = "Press any key for exit";
    const string INPUTTHEAMOUNT = "Input the amount of money";
    const string INPUTTHEPOCDUCTIVITY = "Input nessessary productivity";
    const string CHOOSECRITERIA = "Choose the criteria";
    const string JUNIOR = "Junior";
    const string MIDDLE = "Middle";
    const string SENIOR = "Senior";
    const string LEAD = "Lead";
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
        Console.WriteLine(INPUTTHEAMOUNT);
        int nesessaryAmount = Int32.Parse(Console.ReadLine());
        Console.WriteLine(INPUTTHEPOCDUCTIVITY);
        int nesessaryProductivity = Int32.Parse(Console.ReadLine());
        Console.WriteLine(CHOOSECRITERIA);
        int criteriaNumber = Int32.Parse(Console.ReadLine());
        Mediator mediator = new Mediator(criteriaNumber, nesessaryAmount, nesessaryProductivity, 
                                         listOfAvailableDevelopers);
        mediator.MakeTeam();
        List<Developer> team = new List<Developer>();
        int quantityOfJuniors = 0;
        int quantityOfMiddles = 0;
        int quantityOfSeniors = 0;
        int quantityOfLeads = 0;
        foreach (var developer in mediator.Team)
        {
          team.Add(developer);
          if (developer.Vacancy.Equals(JUNIOR))
          {
            quantityOfJuniors++;
          }
          if (developer.Vacancy.Equals(MIDDLE))
          {
            quantityOfMiddles++;
          }
          if (developer.Vacancy.Equals(SENIOR))
          {
            quantityOfSeniors++;
          }
          if (developer.Vacancy.Equals(LEAD))
          {
            quantityOfLeads++;
          }
        }
        StringBuilder output = new StringBuilder("Team:\n" + LEAD + ": "+ quantityOfLeads.ToString() + "\n" + 
                                                             SENIOR + ": " + quantityOfSeniors.ToString() + "\n" +
                                                             MIDDLE + ": " + quantityOfMiddles.ToString() + "\n" +
                                                             JUNIOR + ": " + quantityOfJuniors.ToString()); 
      }
      finally
      {
        Console.WriteLine(FOREXIT);
        Console.ReadKey();
      }
    }
  }
}
