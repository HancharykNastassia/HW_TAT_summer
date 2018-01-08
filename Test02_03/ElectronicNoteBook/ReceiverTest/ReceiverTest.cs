using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicNoteBook;

namespace ReceiverTest
{
  [TestClass]
  public class ReceiverTest
  {
    [TestMethod]
    public void TestAddNoteToNoteBook()
    {
      DateTime dateTime = DateTime.Now;
      StringBuilder text = new StringBuilder("new text");
      Note note = new Note(dateTime, text);
      NoteBook notebook = new NoteBook(0, DateTime.Now);
      ConcreteCommand addNote = new ConcreteCommand(notebook, note);
      addNote.Execute();
      Assert.AreEqual(dateTime, notebook.Notations[0].DateOfCreation);
      Assert.AreEqual(0, notebook.Id);
    }

    [TestMethod]
    public void TestFindNotesWhithCreationDate()
    {
      DateTime dateTime = DateTime.Now;
      DateTime dateTimeUser = new DateTime(2017, 12, 5, 0, 0, 0);
      NoteBook notebook = new NoteBook();
      List<Note> listOfNotes = new List<Note>();
      List<Note> expected = new List<Note>();

      StringBuilder text = new StringBuilder("new text");
      Note note = new Note(dateTime, text);
      ConcreteCommand addNotes = new ConcreteCommand(notebook, note);
      addNotes.Execute();

      text = new StringBuilder("text");
      note = new Note(dateTimeUser, text);
      addNotes = new ConcreteCommand(notebook, note);
      addNotes.Execute();
      expected.Add(note);

      text = new StringBuilder("new");
      note = new Note(dateTimeUser, text);
      addNotes = new ConcreteCommand(notebook, note);
      addNotes.Execute();
      expected.Add(note);
   
      ConcreteCommand findNotes = new ConcreteCommand(notebook, dateTimeUser, listOfNotes);
      findNotes.Execute();
      listOfNotes = (List<Note>)findNotes.Parametrs[2];
      CollectionAssert.AreEqual(expected, listOfNotes);
    }
  }
}
