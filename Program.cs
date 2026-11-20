// RHS Computing — C# Console Starter
// Start here: press F5 (or choose Run > Start Debugging).

Console.WriteLine("Welcome to RHS Computing!");
Console.WriteLine("Your C# programming environment is working.");
Console.WriteLine();

Console.Write("What is your name? ");
string name = Console.ReadLine() ?? "";

if (string.IsNullOrWhiteSpace(name))
{
    name = "programmer";
}

Console.WriteLine($"Hello, {name}! Ready to code?");

// Your code goes below this line.

