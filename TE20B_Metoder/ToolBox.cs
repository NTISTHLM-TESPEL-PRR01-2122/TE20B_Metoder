using System;

public class ToolBox
{
  public static void WriteCentered(string text)
  {
    // string text = "Hello, world!";

    int numberOfSpaces = Console.WindowWidth / 2 - text.Length / 2;

    int i = 0;
    while (i < numberOfSpaces)
    {
      i++;
      Console.Write(" ");
    }
    Console.WriteLine(text);
  }

  public static void SayHello()
  {
    Console.WriteLine("Hello!");
  }

  public static string WriteSomething()
  {
    string answer = "";
    while (answer == "")
    {
      Console.WriteLine("Write something:");
      answer = Console.ReadLine();
    }

    return answer;
  }


}