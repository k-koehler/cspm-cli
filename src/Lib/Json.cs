using System.Web.Script.Serialization;

namespace Lib
{
  public static class Json
  {
    private static JavaScriptSerializer serializer = new JavaScriptSerializer();

    public static string Stringify(dynamic o)
    {
      return serializer.Serialize(o);
    }

    public static dynamic Parse(string s)
    {
      return serializer.Deserialize<dynamic>(s);
    }
  }
}