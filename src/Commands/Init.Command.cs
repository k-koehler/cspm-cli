using System;
using System.IO;
using System.Text;

using Lib;

namespace Commands
{

  public class InitCommand : Command
  {
    private const string MAIN_CS = @"using System;

class HelloWorld {
  public static void Main(string[] args){
    Console.WriteLine(""Hello World!"");
  }
}";

    public override Result Run()
    {
      if (File.Exists("./project.json"))
      {
        return Result.Error("Project already initialized in this directory.");
      }
      var name = UserInput.Required("project name: ");
      File.WriteAllText("./project.json", Json.Stringify(new
      {
        name = name,
        version = "0.0.1",
        bin = "bin"
      }));
      File.WriteAllText("./Main.cs", MAIN_CS);
      return Result.Success("Initialized project. Hint: try \"cspm run\"");
    }
  }
}