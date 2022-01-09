using System;
using Commands;

public class Reader
{
  private string[] args;

  public Reader(string[] args)
  {
    this.args = args;
  }

  public Command Read()
  {
    if (args.Length < 1)
    {
      return new UsageErrorCommand();
    }
    var commandName = args[0];
    switch (commandName)
    {
      case "init":
        return new InitCommand();
      case "run":
        return new RunCommand();
      default:
        return new UnknownCommandCommand(commandName);
    }
  }
}