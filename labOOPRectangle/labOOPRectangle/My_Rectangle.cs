namespace labOOPRectangle
{
    internal class My_Rectangle
    {
        private int length;
        private int width;

        public My_Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        public My_Rectangle(int length, int width)
        {
            this.length=length;
            this.width=width;
        }

        internal int GetArea()
        {
            return length * width;
        }
    }
}