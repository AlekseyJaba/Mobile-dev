using System.Drawing;

namespace labOOPRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            My_Rectangle x = new();
            Console.WriteLine(x.GetArea());
            My_Rectangle y = new(10, 20);
            Console.WriteLine(y.GetArea());
        }
    }
}