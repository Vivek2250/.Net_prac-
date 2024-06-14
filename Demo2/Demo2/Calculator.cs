using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Calculator
    {
        public void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Addition is: "+sum);
        }
        public void Sub(int x, int y)
        {
            int diff = 0;
            if (x > y) {
                 diff = x - y;
            }
            else
            {
                 diff = y - x;
            }
            Console.WriteLine("Substraction is: "+diff);
        }
        public void Mul(int x,int y)
        {
            int pdt = x * y;
            Console.WriteLine("Multiplication is: "+pdt);
        }
        public void Div(float x, float y)
        {
            float qnt = x / y;
            Console.WriteLine("Division is: "+qnt);
        }

    }
}
