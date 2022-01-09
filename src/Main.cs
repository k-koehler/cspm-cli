class Hello
{
  static void Main(string[] args)
  {
    var reader = new Reader(args);
    var command = reader.Read();
    var result = command.Run();
    var writer = new Writer(result);
    writer.Write();
  }
}