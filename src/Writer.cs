using System;

public class Writer
{
  private Result result;

  public Writer(Result result)
  {
    this.result = result;
  }

  public void Write()
  {
    if (this.result.Text == "")
    {
      return;
    }
    if (result.HasError)
    {
      Console.Error.WriteLine(result.Text);
    }
    else
    {
      Console.WriteLine(result.Text);
    }
  }
}