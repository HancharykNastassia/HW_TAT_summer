using System;
using System.Collections.Generic;

namespace TeamFormation
{
  public class Developer
  {
    int productivity;
    int salary;
    string vacancy;

    public Developer(int productivity, int salary, string vacancy)
    {
      this.productivity = productivity;
      this.salary = salary;
      this.vacancy = vacancy;
    }
    public int Productivity
    {
      get => productivity;
    }
    public int Salary
    {
      get => salary;
    }
    public string Vacancy
    {
      get => vacancy;
    }
  }
}
