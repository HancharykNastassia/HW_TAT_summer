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
            MakeTeamOfMinimumAmountInFixedProductivity();
            break;
          }
        case 3:
          {
            MakeTeamOfMinimumDevelopersInFixedProductivityAcceptJunior();
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
    private void MakeTeamOfMinimumAmountInFixedProductivity()
    {
      int checkSumOfProductivity = 0;
      int checkSumOfSalary = 0;
      foreach (var developer in listOfDevelopers)
      {
        checkSumOfProductivity += developer.Productivity;
        checkSumOfSalary += developer.Salary;
      }
      if (checkSumOfProductivity == productivity)
      {
        foreach (var developer in listOfDevelopers)
        {
          team.Add(developer);
        }
      }
      if (checkSumOfProductivity > productivity)
      {
        int sumSalary = 0;
        int sumProductivity = 0;
        int minSalary = checkSumOfSalary;
        List<Developer> tempList = new List<Developer>();
        foreach (var developer in listOfDevelopers)
        {
          if (developer.Productivity > productivity)
          {
            listOfDevelopers.Remove(developer);
          }
        }
        foreach (var developer in listOfDevelopers)
        {
          if (sumProductivity < productivity)
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
        if (sumProductivity == productivity)
        {
          if (sumSalary < minSalary)
          {
            minSalary = sumSalary;
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
    private void MakeTeamOfMinimumDevelopersInFixedProductivityAcceptJunior()
    {
      int checkSumOfProductivity = 0;
      int checkSumOfSalary = 0;
      foreach (var developer in listOfDevelopers)
      {
        if (developer.Vacancy.Equals("Junior"))
        {
          listOfDevelopers.Remove(developer);
        }
      }
      foreach (var developer in listOfDevelopers)
      {
        checkSumOfProductivity += developer.Productivity;
        checkSumOfSalary += developer.Salary;
      }
      if (checkSumOfProductivity == productivity)
      {
        foreach (var developer in listOfDevelopers)
        {
          team.Add(developer);
        }
      }
      if (checkSumOfProductivity > productivity)
      {
        int sumProductivity = 0;
        int minSalary = checkSumOfSalary;
        int minQuantityOfDevelopers = listOfDevelopers.Capacity; 
        List<Developer> tempList = new List<Developer>();
        foreach (var developer in listOfDevelopers)
        {
          if (developer.Productivity > productivity)
          {
            listOfDevelopers.Remove(developer);
          }
        }
        foreach (var developer in listOfDevelopers)
        {
          if (sumProductivity < productivity)
          {
            sumProductivity += developer.Productivity;
            tempList.Add(developer);
          }
          else
          {
            break;
          }
        }
        if (sumProductivity == productivity)
        {
          if (minQuantityOfDevelopers > tempList.Capacity)
          {
            minQuantityOfDevelopers = tempList.Capacity;
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
