// See https://aka.ms/new-console-template for more information
namespace Oops
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal method");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal Sing");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("dog constructor");
        }
        public void Talk()
        {
            Console.WriteLine("Dog method");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog Sing");
        }
    }

    class StrayDog : Dog
    {
        public StrayDog()
        {
            Console.WriteLine("straydog constructor");
        }
        public void Bark()
        {
            Console.WriteLine("Straydog method");
        }

        public static void Main()
        {
            Animal d1 = new Dog();
            d1.Sing();
            //d1.Talk();
            //d1.Greet();
            //StrayDog s1 = new StrayDog();
            //s1.Bark();
            //s1.Greet();
            //s1.Talk();
        }
    }
}
