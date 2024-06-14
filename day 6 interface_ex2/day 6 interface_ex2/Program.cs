using day_6_interface_ex2;

class program
{
    public static void Main()
    {
        Calculator cal1 = new Calculator();
        Console.WriteLine("Addition: " + cal1.add(4, 7));
        Console.WriteLine("Subtraction: " + cal1.sub(4, 7));
        Console.WriteLine("Multiplication: " + cal1.mul(4, 7));
        Console.WriteLine("Division: " + cal1.div(4, 7));
    }
}