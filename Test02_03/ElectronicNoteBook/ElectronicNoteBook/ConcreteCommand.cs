using System;

namespace ElectronicNoteBook
{
  /// <summary>
  /// This class is used to call commands
  /// </summary>
  public class ConcreteCommand : Command
  {
    Receiver receiver;
    public object[] Parametrs { get; }

    public ConcreteCommand(params object[] parametrs)
    {
      this.Parametrs = new object[parametrs.Length];
      Array.Copy(parametrs, this.Parametrs, parametrs.Length);
      receiver = new Receiver();
    }

    /// <summary>
    /// Calls commands
    /// </summary>
    public override void Execute()
    {
      receiver.SwitchOperation(Parametrs);
    }
  }
}
