Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Red on white color");
Console.ResetColor();
Console.WriteLine("Manual text");
foreach(var color in Enum.GetValues<ConsoleColor>())
{
    Console.ForegroundColor = color;
    Console.WriteLine(color);
}