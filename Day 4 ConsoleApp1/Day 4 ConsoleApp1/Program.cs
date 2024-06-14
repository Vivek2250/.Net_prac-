// See https://aka.ms/new-console-template for more information
namespace oops
{
    class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am an Animal");
        }
    }

    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is: " + name);
        }
    }

    class program {
        public static void Main()
        {
            Dog labrador = new Dog();
            labrador.name = "Bunny";
            labrador.display();
            labrador.getName();
        }
    }
    
}
