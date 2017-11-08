using System;
using System.Collections.Generic;

namespace TeamFormation
{
  class Mediator
  {
    int criteria;
    int amount;
    int productivity;
    List<Developer> listOfDevelopers;
    List<Developer> team;
    public List<Developer> Team
    {
      get => team;
    }
    public Mediator(int criteria, int amount, int productivity, List<Developer> list)
    {
      this.criteria = criteria;
      this.amount = amount;
      this.productivity = productivity;
      listOfDevelopers = list;
    }
    public void MakeTeam()
    {
      switch (criteria)
      {
        case 1:
          {
            MakeTeamOfMaximumProductivityInFixedAmount();
            break;
          }
        case 2:
          {
            break;
          }
        case 3:
          {
            break;
          }
        default: throw new Exception();
      }
    }
    private void MakeTeamOfMaximumProductivityInFixedAmount()
    {
      int checkSumOfSalary = 0;
      foreach(var developer in listOfDevelopers)
      {
        checkSumOfSalary += developer.Salary;
      }
      if (checkSumOfSalary == amount)
      {
        foreach (var developer in listOfDevelopers)
        {
          team.Add(developer);
        }
      }
      if (checkSumOfSalary > amount)
      {
        int sumSalary = 0;
        int sumProductivity = 0;
        int maxProductivity = 0;
        List<Developer> tempList = new List<Developer>();
        foreach (var developer in listOfDevelopers)
        {
          if (developer.Salary > amount)
          {
            listOfDevelopers.Remove(developer);
          }
        }
        foreach(var developer in listOfDevelopers)
        { 
          if (sumSalary < amount)
          {
            sumSalary += developer.Salary;
            sumProductivity += developer.Productivity;
            tempList.Add(developer);
          }
          else
          {
            break;
          }
        }
        if (sumSalary == amount)
        {
          if (sumProductivity > maxProductivity)
          {
            maxProductivity = sumProductivity;
            team.Clear();
            foreach (var developer in tempList)
            {
              team.Add(developer);
            }
          }
        }
        tempList.Clear();
      }
    }
  }
}
