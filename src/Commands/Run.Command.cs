using System;
using System.Diagnostics;
using System.IO;

namespace Commands
{

  public class RunCommand : ProjectJsonCommand
  {
    public override Result Run(ProjectJson project)
    {
      if (!Directory.Exists(project.Bin))
      {
        Directory.CreateDirectory(project.Bin);
      }
      var compileProcess = Process.Start(
        "mcs",
        $"-out:{project.Bin}/Main.exe -recurse:*.cs"
      );
      compileProcess.WaitForExit();
      var runProcess = Process.Start("mono", "bin/Main.exe");
      runProcess.WaitForExit();
      return Result.Success();
    }
  }
}