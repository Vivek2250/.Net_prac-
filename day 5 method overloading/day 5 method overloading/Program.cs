
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class program
{
    class calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public int sub(int a, int b)
        {
            int diff = a - b;
            return diff;
        }

        public double sub(double a, double b)
        {
            double diff = a - b;
            return diff;
        }

        public int mul(int a, int b)
        {
            int pdt = a * b;
            return pdt;
        }

        public double mul(double a, double b)
        {
            double pdt = a * b;
            return pdt;
        }



        public static void Main()
        {
            calculator cal = new calculator();
            int sum1 = cal.Add(2, 3);
            Console.WriteLine(sum1);
            int sum2= cal.Add(2, 5, 7);
            Console.WriteLine(sum2);
            double sum3 =  cal.Add(2.6,6.9);
            Console.WriteLine(sum3);

            int diff1 = cal.sub(5, 2);
            Console.WriteLine(sum1);
            double diff2 = cal.sub(9.87, 7.22);
            Console.WriteLine(sum2);

            int pdt1 = cal.mul(5, 9);
            Console.WriteLine(pdt1);
            double pdt2 = cal.mul(9.37, 7.982);
            Console.WriteLine(pdt2);
        }

    }
}
