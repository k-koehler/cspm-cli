using Lib;

namespace Commands
{
  public class UnknownCommandCommand : Command
  {

    private string commandName;

    public UnknownCommandCommand(string commandName)
    {
      this.commandName = commandName;
    }

    public override Result Run()
    {
      return Result.Error(new MultilineString($@"Unknown command: {this.commandName}
      
      For help: cspm help").ToString());
    }
  }
}