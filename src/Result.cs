public class Result
{
  public bool HasError;
  public string Text;

  public static Result Success()
  {
    return new Result { HasError = false, Text = "" };
  }
  public static Result Success(string text)
  {
    return new Result { HasError = false, Text = text };
  }

  public static Result Error(string text)
  {
    return new Result { HasError = true, Text = text };
  }
}