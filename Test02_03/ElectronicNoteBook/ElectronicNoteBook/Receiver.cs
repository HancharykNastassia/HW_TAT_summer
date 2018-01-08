using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class trys to execute commands
  /// </summary>
  public class Receiver
  {
    /// <summary>
    /// This method analyses input arguments and choses command to execute
    /// </summary>
    /// <param name="par">Arguments to analyse and use for execution of commands</param>
    public void SwitchOperation(params object[] par)
    {
      if (par[0].GetType().Equals(typeof(NoteBook)))
      {
        if (par.Length == 1)
        {
          if (par[0].Equals(null))
          {
            CreateNewNoteBook((NoteBook)par[0]);
          }
          else
          {
            ShowNotationsOfNoteBook((NoteBook)par[0]);
          }
        }
        else if (par.Length == 2)
        {
          if (par[1].GetType().Equals(typeof(Note)))
          {
            Note note = (Note)par[1];
            AddNoteToNoteBook((NoteBook)par[0], note);
          }
          else
          {
            throw new FormatException();
          }
        }
        else if (par.Length == 3)
        {
          if (par[1].GetType().Equals(typeof(bool)) && par[2].GetType().Equals(typeof(string)))
          {
            bool isToWriteToFile = (bool)par[1];
            string fileName = (string)par[2];
            if (isToWriteToFile)
            {
              WriteNoteBookToFile((NoteBook)par[0], fileName);
            }
            else
            {
              ReadNoteBookFromFile((NoteBook)par[0], fileName);
            }
          }
          else if (par[2].GetType().Equals(typeof(List<Note>)))
          {
            if (par[1].GetType().Equals(typeof(DateTime)))
            {
              FindNotesWhithCreationDate((NoteBook)par[0], (DateTime)par[1], (List<Note>)par[2]);
            }
            else if(par[1].GetType().Equals(typeof(StringBuilder)))
            {
              FindNotesWhithNotetions((NoteBook)par[0], (StringBuilder)par[1], (List<Note>)par[2]);
            }
          }
          else
          {
            throw new FormatException();
          }
        }
      }
      else
      {
        throw new FormatException();
      }
    }

    /// <summary>
    /// Creates new notebook
    /// </summary>
    /// <param name="noteBook">notebook to create</param>
    public void CreateNewNoteBook(NoteBook noteBook)
    {
      noteBook = new NoteBook();
    }

    /// <summary>
    /// Adds new note to notebook
    /// </summary>
    /// <param name="noteBook">notbook to which note should be added</param>
    /// <param name="noteToAdd">Note to add</param>
    public void AddNoteToNoteBook(NoteBook noteBook, Note noteToAdd)
    {
      noteBook.Notations.Add(noteToAdd);
    }

    /// <summary>
    /// Finds notes with notations
    /// </summary>
    /// <param name="noteBook">notebook where to search</param>
    /// <param name="notations">text to search for</param>
    /// <param name="foundNotes">list of found notes</param>
    public void FindNotesWhithNotetions(NoteBook noteBook, StringBuilder notations, List<Note> foundNotes)
    {
      foundNotes = new List<Note>();
      foreach (Note note in noteBook.Notations)
      {
        if (note.Notation.Equals(notations))
        {
          foundNotes.Add(note);
        }
      }
    }

    /// <summary>
    /// Finds notes with date and time of creation
    /// </summary>
    /// <param name="noteBook">notebook where to search</param>
    /// <param name="timeAndDate">date and time of creation</param>
    /// <param name="foundNotes">list of found notes</param>
    public void FindNotesWhithCreationDate(NoteBook noteBook, DateTime timeAndDate, List<Note> foundNotes)
    {
      foundNotes = new List<Note>();
      foreach (Note note in noteBook.Notations)
      {
        if (note.DateOfCreation.Equals(timeAndDate))
        {
          foundNotes.Add(note);
        }
      }
    }

    /// <summary>
    /// Printes notebook to the console
    /// </summary>
    /// <param name="noteBook">notebook to print</param>
    public void ShowNotationsOfNoteBook(NoteBook noteBook)
    {
      new NoteBookConsoleView(noteBook).Print();
    }

    /// <summary>
    /// Writes notebook to the file
    /// </summary>
    /// <param name="noteBook">notebook to write</param>
    /// <param name="fileName">name of file to write in</param>
    public void WriteNoteBookToFile(NoteBook noteBook, string fileName)
    {
      using (StreamWriter writerToFile = new StreamWriter(fileName))
      {
        writerToFile.Write(noteBook.ToString());
      }
    }

    /// <summary>
    /// Reads notebook from file
    /// </summary>
    /// <param name="noteBook">notebook to read in</param>
    /// <param name="fileName">name of file</param>
    public void ReadNoteBookFromFile(NoteBook noteBook, string fileName)
    {
      using (StreamReader readerFromFile = new StreamReader(fileName))
      {
        Note note = new Note();
        int count = 0;
        while (!readerFromFile.EndOfStream)
        {
          string text = readerFromFile.ReadLine();
          DateTime dateTime;
          if (DateTime.TryParse(text, out dateTime))
          {
            count++;
            if (count > 1)
            {
              noteBook.Notations.Add(note);
              note = new Note();
            }
            note.DateOfCreation = dateTime;
          }
          else
          {
            note.Notation.Append(text);
          }
        }
      }
    }
  }
}
