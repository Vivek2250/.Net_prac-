class program
{
    class Car
    {
        public virtual void Brakes()
        {
            Console.WriteLine("Generic brakes applied");
        }
    }

    class Sportscar: Car
    {
        public override void Brakes()
        {
            Console.WriteLine("High performance brakes applied");
        }
    }

    public static void Main()
    {
        Car car1 = new Car();
        car1.Brakes();

        Car car2 = new Sportscar();
        car2.Brakes();
    }
}