using System.Collections.Generic;

namespace Lib
{
  public class MultilineString
  {
    private string s;

    public MultilineString(string s)
    {
      this.s = s;
    }

    public override string ToString()
    {
      var lines = new List<string>();
      var cur = "";
      var encountedValidChar = false;
      foreach (var ch in this.s)
      {
        if (ch == '\n')
        {
          lines.Add(cur + ch);
          cur = "";
          encountedValidChar = false;
        }
        else if (!encountedValidChar && (ch == ' ' || ch == '\t'))
        {
          continue;
        }
        else
        {
          cur += ch;
          encountedValidChar = true;
        }
      }
      if (cur != "")
      {
        lines.Add(cur);
      }
      var result = "";
      foreach (var s in lines)
      {
        result += s;
      }
      return result;
    }
  }
}