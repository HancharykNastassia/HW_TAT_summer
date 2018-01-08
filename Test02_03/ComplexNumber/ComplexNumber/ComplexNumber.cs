using System;

namespace ComplexNumberNs
{
  /// <summary>
  /// This class represents Complex number
  /// </summary>
  public class ComplexNumber : IComparable<ComplexNumber>
  {
    private double re;
    private double im;

    public double Re
    {
      get
      {
        return re;
      }
      set
      {
        re = value;
      }
    }

    public double Im
    {
      get
      {
        return im;
      }
      set
      {
        im = value;
      }
    }

    /// <summary>
    /// Trivial defaulf constructor
    /// </summary>
    public ComplexNumber()
    {
      re = 0.0;
      im = 0.0;
    }

    /// <summary>
    /// Trivial constructor
    /// </summary>
    /// <param name="re">Initial value for real part of complex number</param>
    /// <param name="im">Initial value for imaginary part of complex number</param>
    public ComplexNumber(double re, double im)
    {
      this.re = re;
      this.im = im;
    }

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="number">Initial value type of ComplexNumber</param>
    public ComplexNumber(ComplexNumber number)
    {
      re = number.Re;
      im = number.Im;
    }
    /// <summary>
    /// Override operator + for ComplexNumber
    /// </summary>
    /// <param name="firstNumber">First additive number</param>
    /// <param name="secondeNumber">Seconde additive number</param>
    /// <returns>New CompexNumber which is the result of addition</returns>
    public static ComplexNumber operator +(ComplexNumber firstNumber, ComplexNumber secondeNumber)
    {
      ComplexNumber resultNumber = new ComplexNumber();
      resultNumber.Re = firstNumber.Re + secondeNumber.Re;
      resultNumber.Im = firstNumber.Im + secondeNumber.Im;
      return resultNumber;
    }

    /// <summary>
    /// Override operator - for ComplexNumber
    /// </summary>
    /// <param name="firstNumber">Minuend</param>
    /// <param name="secondeNumber">Subtrahend</param>
    /// <returns>New CompexNumber which is the result of subtraction</returns>
    public static ComplexNumber operator -(ComplexNumber firstNumber, ComplexNumber secondeNumber)
    {
      ComplexNumber resultNumber = new ComplexNumber();
      resultNumber.Re = firstNumber.Re - secondeNumber.Re;
      resultNumber.Im = firstNumber.Im - secondeNumber.Im;
      return resultNumber;
    }

    /// <summary>
    /// Override operator * for ComplexNumber
    /// </summary>
    /// <param name="firstNumber">First factor</param>
    /// <param name="secondeNumber">Second factor</param>
    /// <returns>New CompexNumber which is the result of multiplication</returns>
    public static ComplexNumber operator *(ComplexNumber firstNumber, ComplexNumber secondeNumber)
    {
      ComplexNumber resultNumber = new ComplexNumber();
      resultNumber.Re = firstNumber.Re * secondeNumber.Re - firstNumber.Im * secondeNumber.Im;
      resultNumber.Im = firstNumber.Re * secondeNumber.Im + firstNumber.Im * secondeNumber.Re;
      return resultNumber;
    }

    /// <summary>
    /// Override operator / for ComplexNumber
    /// </summary>
    /// <param name="firstNumber">Dividend</param>
    /// <param name="secondeNumber">Devider</param>
    /// <returns>New CompexNumber which is the result of devision</returns>
    public static ComplexNumber operator /(ComplexNumber firstNumber, ComplexNumber secondeNumber)
    {
      ComplexNumber resultNumber = new ComplexNumber();
      resultNumber.Re = (firstNumber.Re * secondeNumber.Re + firstNumber.Im * secondeNumber.Im) /
                        (Math.Pow(secondeNumber.Re, 2) + Math.Pow(secondeNumber.Im, 2));
      resultNumber.Im = (secondeNumber.Re * firstNumber.Im - firstNumber.Re * secondeNumber.Im) /
                        (Math.Pow(secondeNumber.Re, 2) + Math.Pow(secondeNumber.Im, 2)); ;
      return resultNumber;
    }

    /// <summary>
    /// Counts module of complex number
    /// </summary>
    /// <returns>Module of complex number type of double</returns>
    public double CountModule()
    {
      return Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
    }

    /// <summary>
    /// Compares module of other complex number with module of this one 
    /// </summary>
    /// <param name="other">Other complex number</param>
    /// <returns>0 if modules are equal, -1 if module of other is bigger, and 1 if module of other is smaller</returns>
    public int CompareTo(ComplexNumber other)
    {
      if (Math.Abs(CountModule() - other.CountModule()) < Double.Epsilon)
      {
        return 0;
      }
      if ((CountModule() - other.CountModule()) < Double.Epsilon)
      {
        return -1;
      }
      return 1;
    }

    /// <summary>
    /// Convertes ComlexNumber item to string
    /// </summary>
    /// <returns>String representation of ComlexNumber item</returns>
    public override string ToString()
    {
      string output = re.ToString() + "+ j" + im.ToString();
      return output;
    }
  }
}
