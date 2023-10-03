//Dict
// key - item

Dictionary<int, string> x = new();
x.Add(10, "Kaluga");
x.Add(75, "Moscow");
x.Add(25, "Iam");
Console.WriteLine(x[75]);
x[75] = "Voronezh";
x[99] = "Kaliningrad";
foreach (var item in x)
{
    Console.WriteLine(item);  
}
foreach (var item in x)
{
    Console.WriteLine($"key = {item.Key}, value = {item.Value}");
}
