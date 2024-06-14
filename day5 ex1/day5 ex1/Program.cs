class program
{
    class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Animal noise");
        }
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    
    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public static void Main()
    {
        Animal ani = new Animal();
        Animal ani1 = new Dog();
        Animal ani2 = new Cat();
        ani.makeSound();
        ani1.makeSound();
        ani2.makeSound();
    }
}
