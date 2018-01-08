using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class is used to write a note, some notes or whole notebook to the console
  /// </summary>
  public class NoteBookConsoleView
  {
    const string TOOBIGNUMBER = "There is no note with number ";
    NoteBook noteBook;

    /// <summary>
    /// Trivial constructor
    /// </summary>
    /// <param name="noteBook">Notebook which notes are to write to console</param>
    public NoteBookConsoleView(NoteBook noteBook)
    {
      this.noteBook = noteBook;
    }

    /// <summary>
    /// This method writes some notes or whole noteBook to the console
    /// </summary>
    /// <param name="parameters">Parametrs which can help to decide what notes of noteboom are to print.
    /// If there are DateTime parameters all notes of this date and time will be printed.
    /// If there are StringBuilder notations parameters all notes of this title will be printed.
    /// In other cases it throws exceptions.</param>
    public void Print(params object[] parameters)
    {
      StringBuilder output = new StringBuilder();
      if (parameters.Length <= 0)
      {
        output.Append(noteBook.ToString());
      }
      else
      {
        if (parameters.GetType().Equals(typeof(StringBuilder[])) || parameters.GetType().Equals(typeof(StringBuilder)) ||
            parameters.GetType().Equals(typeof(DateTime[])) || parameters.GetType().Equals(typeof(DateTime)))
        {
          List<Note> listsToPrint = new List<Note>();
          foreach (var parameter in parameters)
          {
            new ConcreteCommand(noteBook, parameter, listsToPrint).Execute();
            if (listsToPrint.Capacity > 0)
            {
              foreach (Note note in listsToPrint)
              {
                output.Append(note.ToString());
              }
            }
          }
        }
        else
        {
          throw new FormatException();
        }
      }
      Console.WriteLine(output);
    }
  }
}
