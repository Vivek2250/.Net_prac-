class peogram
{
    class Rectangle
    {
        public int calArea(int x, int y)
        {
            int area = x * y;
            return area;
        }

        public int calArea(int x)
        {
            int area = x * x;
            return area;
        }

    }
     public static void Main()
    {
        Rectangle rect = new Rectangle();
        Console.WriteLine("Area of rectangle is: " + rect.calArea(4, 5));

        Rectangle square = new Rectangle();
        Console.WriteLine("Area of square is: " + square.calArea(5));
    }
}