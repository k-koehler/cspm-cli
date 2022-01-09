using System.IO;

using Lib;

namespace Commands
{
  public class ProjectJson
  {
    public string Name;
    public string Version;
    public string Bin;
  }

  public abstract class ProjectJsonCommand : Command
  {
    public override Result Run()
    {
      if (!File.Exists("./project.json"))
      {
        return Result.Error("Could not find project.json. Have you typed \"cspm init\" yet?");
      }
      var data = Json.Parse(File.ReadAllText("./project.json"));
      return Run(new ProjectJson
      {
        Name = data["name"],
        Version = data["version"],
        Bin = data["bin"]
      });
    }

    public abstract Result Run(ProjectJson project);
  }
}