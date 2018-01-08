using System;

namespace Cars
{
  /// <summary>
  /// This class was created to sort array of structs "Car".
  /// </summary>
  public class CarSorter
  {
    Car[] cars;
    int quantityOfPermutations;
    public Car[] Cars
    {
      get
      {
        return cars;
      }
    }

    public CarSorter(Car[] arrayOfCars)
    {
      this.cars = new Car[arrayOfCars.Length];
      Array.Copy(arrayOfCars, cars, arrayOfCars.Length);
    }

    /// <summary>
    /// This method sortes the array of structs "Car" with next rules:
    /// 1) Sort with the value of field "cost" of the struct "Car";
    /// 2) Sort with the value of field "mark" of the sruct, where the "cost" is equal;
    /// 3) Sort with the value of field "model" of the sruct, where the "mark" is equal;
    /// 4) Sort with the value of field "type" of the sruct, where the "model" is equal;
    /// </summary>
    public void SortCars()
    {
      do
      {
        quantityOfPermutations = 0;
        for (int i = 0; i < cars.Length - 1; i++)
        {
          if (cars[i].cost == cars[i + 1].cost)
          {
            if (cars[i].mark.Equals(cars[i + 1].mark))
            {
              if (cars[i].model.Equals(cars[i + 1].model))
              {
                if (!cars[i].type.Equals(cars[i + 1].type) && IsExchangeNessessary(cars[i].type, cars[i + 1].type))
                {
                  ExchangePlaces(i);
                  quantityOfPermutations++;
                }
              }
              else if (IsExchangeNessessary(cars[i].model, cars[i + 1].model))
              {
                ExchangePlaces(i);
                quantityOfPermutations++;
              }
            }
            else if (IsExchangeNessessary(cars[i].mark, cars[i + 1].mark))
            {
              ExchangePlaces(i);
              quantityOfPermutations++;
            }
          }
          else if (cars[i].cost > cars[i + 1].cost)
          {
            ExchangePlaces(i);
            quantityOfPermutations++;
          }
        }
      }
      while (quantityOfPermutations > 0);
    }
    
    //This method checks if two strings are not in alfabet order
    private bool IsExchangeNessessary(string firstLine, string secondLine)
    {
      string firstLineInLower = firstLine.ToLower();
      string secondLineInLower = secondLine.ToLower();
      int length = firstLineInLower.Length > secondLineInLower.Length ? secondLineInLower.Length : firstLineInLower.Length;
      for (int i = 0; i < length; i++)
      {
        if (firstLineInLower[i] < secondLineInLower
          [i])
        {
          return true;
        }
      }
      return false;
    }
    //This method makes two members of array of structs "Car" exchenge places 
    private void ExchangePlaces(int i)
    {
      Car tempCar = cars[i];
      cars[i] = cars[i + 1];
      cars[i + 1] = tempCar;
    }
  }
}