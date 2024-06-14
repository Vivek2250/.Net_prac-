using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_interface_ex3
{
    internal interface IAnimal
    {
        public void display();
    }

    public class Dog : IAnimal
    {
        public void display()
        {
            Console.WriteLine("I am a Dog");
        }
    }

    public class Cat : IAnimal
    {
        public void display()
        {
            Console.WriteLine("I am a Cat");
        }
    }

    public class Lion : IAnimal
    {
        public void display()
        {
            Console.WriteLine("I am a Lion");
        }
    }
}
