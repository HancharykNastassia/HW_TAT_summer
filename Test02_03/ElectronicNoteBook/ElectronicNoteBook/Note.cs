using System;
using System.Text;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class represents notes of notebook
  /// </summary>
  public class Note
  {
    public DateTime DateOfCreation { get; set; }
    public StringBuilder Notation { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public Note ()
    {
      DateOfCreation = DateTime.Now;
      Notation = new StringBuilder(String.Empty);
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="dateTimeOfCreation">date and time of creation</param>
    /// <param name="data">data of note</param>
    public Note(DateTime dateTimeOfCreation, StringBuilder data)
    {
      DateOfCreation = dateTimeOfCreation;
      Notation = data;
    }

    /// <summary>
    /// Checks if object is equal to this note
    /// </summary>
    /// <param name="obj">object to compare with</param>
    /// <returns>True if object equal to this note and false if it is not</returns>
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      Note note = (Note)obj;
      return (DateOfCreation.Equals(note.DateOfCreation)) && (Notation.Equals(note.Notation));
    }

    /// <summary>
    /// Gets Hash Code
    /// </summary>
    /// <returns>minutes of creation multiplied by seconds and milliseconds of creation divided by 1000</returns>
    public override int GetHashCode()
    {
      return DateOfCreation.Minute * DateOfCreation.Second * DateOfCreation.Millisecond / 1000;
    }

    /// <summary>
    /// Represents Note as string
    /// </summary>
    /// <returns>String representation of Note</returns>
    public override string ToString()
    {
      StringBuilder output = new StringBuilder("Date and time of creation: " + DateOfCreation.ToString() + "\n");
      output.Append(Notation);
      return output.ToString();
    }
  }
}
