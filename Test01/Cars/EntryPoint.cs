using System;
using System.Text;

namespace Cars
{
  class EntryPoint
  {
    const string ENTERNUMBEROFCARS = "Enter the number of cars";
    const string ENTERMARK = "Input the mark of a car:";
    const string ENTERMODEL = "Input the model of the car:";
    const string ENTERTYPE = "Input the type of the car:";
    const string ENTECOST = "Input the cost of the car:";
    const string REPEATINPUT = "Please, try your whole input again";
    static void Main(string[] args)
    {
      bool errorInInput = false;
      Car[] cars = { new Car()};
      do
      {
        try
        {
          errorInInput = false;
          Console.WriteLine(ENTERNUMBEROFCARS);
          cars = new Car[int.Parse(Console.ReadLine())];
          for (int i = 0; i < cars.Length; i++)
          {
            Console.WriteLine(ENTERMARK);
            string mark = Console.ReadLine();
            Console.WriteLine(ENTERMODEL);
            string model = Console.ReadLine();
            Console.WriteLine(ENTERTYPE);
            string type = Console.ReadLine();
            int cost = 0;
            do
            {
              Console.WriteLine(ENTECOST);
              cost = int.Parse(Console.ReadLine());
            } while (cost <= 0);
            cars[i] = new Car(mark, model, type, cost);
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          Console.WriteLine(REPEATINPUT);
          errorInInput = true;
          cars = new Car[0];
        }
      } while (errorInInput);
      CarSorter carSorter = new CarSorter(cars);
      carSorter.SortCars();
      Car[] carsForOutput = new Car[cars.Length];
      Array.Copy(carSorter.Cars, carsForOutput, carsForOutput.Length);
      StringBuilder output = new StringBuilder();
      foreach (Car car in carsForOutput)
      {
        output.Append(car.cost + "\n" + car.mark + "\n" + car.model + "\n" + car.type + "\n" + "\n");
      }
      Console.WriteLine(output);
    }
  }
}
