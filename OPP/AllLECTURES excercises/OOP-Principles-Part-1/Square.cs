namespace OOP_Principles_Part_1
{
    internal class Square : IShapecs
    {
        private int x, y, size;
        public Square(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()
        {
            return size * size;
        }
    }
}
