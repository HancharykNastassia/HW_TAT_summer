using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
  public struct Car
  {
    public string mark;
    public string model;
    public string type;
    public int cost;
    public Car(string mark, string model, string type, int cost)
    {
      this.mark = mark;
      this.model = model;
      this.type = type;
      this.cost = cost;
    }
  }
}
