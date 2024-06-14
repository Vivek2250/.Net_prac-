namespace day12_delegates
{
    delegate void CustomDel(string s);

    public delegate void Operations(int num);

    public class MathsOperations
    {
        public static void AddTen(int num)
        {
            Console.WriteLine($"{num} + 10 = {num + 10}");
        }

        public static void MulByTwo(int num)
        {
            Console.WriteLine($"{num}*2 = {num*2}");
        }

        public static void SubtractFive(int num)
        {
            Console.WriteLine($"{num}-5 = {num - 5}");
        }
    }

    public class TestClass
    {
       //static void Hello(string s)
       // {
       //     Console.WriteLine($" Hello, {s}!");
       // }

       // static void Bye(string s)
       // {
       //     Console.WriteLine($" Bye, {s}!");
       // }

        public class Function
        {
            public static int Sum(int x, int y)
            {
                
                return x + y;
            }
        }

        class Action
        {
            public static void ConsolePrint(int i)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            //CustomDel hiDel, byeDel, multiDel, multiMinusDel;
            //hiDel = Hello;

            //Console.WriteLine("Invoking Delegate");
            //hiDel("Abdullah");

            //byeDel = Bye;
            //byeDel("Abdullah");

            //multiDel = hiDel + byeDel;
            //Console.WriteLine("Invoking multiDel Delegate");
            //multiDel("Abdullah");

            //multiMinusDel = multiDel - hiDel;
            //multiMinusDel("Abdullah");

            //Operations op;
            //op = MathsOperations.AddTen;
            //op += MathsOperations.MulByTwo;
            //op += MathsOperations.SubtractFive;

            //op(5);

            //Using the Func keyword
            //Func<int, int, int> add = Function.Sum;
            //int result = add(10,10);

            //Console.WriteLine(result);

            Action<int> action = Action.ConsolePrint;
            action(10);

            

        }
    }   
}