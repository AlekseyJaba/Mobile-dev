Console.WriteLine("Hello, Vik!\n");
string[] cities = { "Tula", "Moscow", "Kiev", "Minsk" };
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]);
Console.WriteLine($"Длинна: {cities.Length}");
Console.WriteLine("Глупый метод\n");
//1
for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}
Console.WriteLine("Умный метод\n");
//2
foreach (var city in cities)
{
    Console.WriteLine(city);
}
//3
Console.WriteLine("\n");
Console.WriteLine(String.Join<string>("\n", cities));

Array.Resize<string>(ref cities, 10);
cities[5] = "RRRRRRRRRR";
Console.WriteLine(string.Join("\n", cities));
