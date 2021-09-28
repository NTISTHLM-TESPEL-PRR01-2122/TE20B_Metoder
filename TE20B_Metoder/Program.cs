using System;

// Console.WriteLine("Hello World!");
// string name = Console.ReadLine();

// string name = WriteSomething();

// Console.WriteLine($"Hello {name}!");

// ToolBox.WriteCentered("Hej TE20B-spel!");

DoThing();

Console.ReadLine();

static void DoThing()
{
  Console.WriteLine("Doing!");
  // ApplyThing();
  DoThing();
}

static void ApplyThing()
{
  Console.WriteLine("Applying!");
  // DoThing();
}