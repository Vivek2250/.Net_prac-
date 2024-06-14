using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_interface_ex2
{
    internal interface ICalculator
    {
        public int add(int x, int y);
        public int sub(int x, int y);
        public int mul(int x, int y);
        public double div(double x, double y);
    }

    class Calculator : ICalculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            if (x > y)
                return x - y;

            else
                return y - x;
        }

        public int mul(int x, int y)
        {
            return x * y;
        }

        public double div(double x, double y)
        {
            return x / y;
        }
    }
}
