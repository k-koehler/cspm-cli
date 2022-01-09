using System;

namespace Lib
{
  public static class UserInput
  {
    public static string Required(string prompt)
    {
      string input = "";
      do
      {
        Console.Write(prompt);
        input = Console.ReadLine();
      } while (input == "");
      return input;
    }
  }
}