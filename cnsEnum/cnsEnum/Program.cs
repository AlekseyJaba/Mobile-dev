namespace cnsEnum
{
    internal class Program
    {
        public enum SingleColor { Red, Green = 1500, Blue }

        public enum MultiColor 
        { 
            Red = 1,  //0b_0000_0001
            Blue = 2, //0b_0000_0010
            Green = 3 //0b_0000_0100
                All = Red | Green | Blue,
                RG = Red | Green
        }
        public enum MultiColor1 
        { 
            Red = 1,  //0b_0000_0001
            Blue = 1 << 1, //0b_0000_0010
            Green = 1 << 2 //0b_0000_0100
        }
        static void Main(string[] args)
        {
            SingleColor singleColor, singleColor1;
            singleColor = SingleColor.Red;
            singleColor1 = SingleColor.Green;
            Console.WriteLine(singleColor);
            Console.WriteLine(singleColor.ToString("D"));
            Console.WriteLine(singleColor1);
            Console.WriteLine(singleColor1.ToString("D"));

            MultiColor multiColor = MultiColor.Red; 
            multiColor |= MultiColor.Green; //добавить
            multiColor |= MultiColor.Blue; //добавить
            Console.WriteLine(multiColor);
            multiColor ^= MultiColor.Blue; // удалить
            Console.WriteLine(multiColor);
            Console.WriteLine($" Its only red {multiColor == MultiColor.Red}");
            Console.WriteLine($" Has red {multiColor.HasFlag(MultiColor.Red)}");
        }
    }
}