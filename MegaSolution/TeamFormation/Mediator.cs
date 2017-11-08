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
        team = listOfDevelopers;
      }
      if (checkSumOfSalary > amount)
      {

      }
    }
  }
}
