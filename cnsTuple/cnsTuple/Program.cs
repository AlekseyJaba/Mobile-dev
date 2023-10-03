// tuple

int z1 = 5;
var z2 = 6;

//(1)
var x1 = (12, "Hello", true, 3.14);
(int, string, bool, double) x1b = (12, "Hello", true, 3.14);
Console.WriteLine(x1.Item1);
Console.WriteLine(x1.Item2);
Console.WriteLine(x1.Item3);
Console.WriteLine(x1.Item4);

Console.WriteLine("\n=========2 пример=========\n");

(int min, int max) x2 = (2, 4);
Console.WriteLine(x2.min);
Console.WriteLine(x2.max);

Console.WriteLine("\n=========3 пример (Распаковка кортежа )=========\n");

var (min, max) = (2, 4);
Console.WriteLine(min);
Console.WriteLine(max);

Console.WriteLine("\n=========4 пример=========\n");

var x4 = (min: 2,  max: 4);
Console.WriteLine(x4.min);
Console.WriteLine(x4.max);

Console.WriteLine("\n=========5 пример c функциями=========\n");

var x5 = GetX5();

//(int, int) GetX5()
//{
//    return (1, 2);
//}
var x7 = GetX7(2, (2, 3));
Console.WriteLine(x7.min);
Console.WriteLine(x7.max);

(int, int) GetX5() => (1, 2);
(int min, int max) GetX6() => (1, 2);
(int min, int max) GetX7(int y, (int a, int b) ab) => (y + ab.a, y + ab.b);
