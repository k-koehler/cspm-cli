using Lib;

namespace Commands
{
  public class UsageErrorCommand : Command
  {

    public override Result Run()
    {
      return Result.Error(new MultilineString(@"cspm <command>
      
      Usage:

      cspm init            -- initialize the project
      cspm build           -- compile the project
      cspm run             -- run the project
      cspm install <foo>   -- install <foo> package ").ToString());
    }
  }
}