using day_6_abstract_class_ex1;

class program
{
    public static void Main()
    {
        AbsDerived ad1 = new AbsDerived();
        Console.WriteLine("Addition: " + ad1.add(98, 87));
        Console.WriteLine("Multiplication: " + ad1.mul(54,7));
            
    }
}