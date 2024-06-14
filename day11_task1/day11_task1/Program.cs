namespace day11
{
    class program
    {
      public static void Main()
        {
            int[] numbers = { 2, 8, 5, 6, 1, 4, 7, 3, 9, 10 };

            findEven(numbers);
            findOdd(numbers);
            find3Smallest(numbers);
            calculateSum(numbers);
            findMAXnMIN(numbers);
            findAverage(numbers);
            NumbersnSquares(numbers);
            FilternSort(numbers);
        }

        //Print all even numbers
        public static void findEven(int[] numbers)
        {
            IEnumerable<int> query = numbers.Where(s => s % 2 == 0);
            foreach (int n in query)
            {
                Console.WriteLine(n);
            }
        }

        //Find all odd numbers greater than 5
        public static void findOdd(int[] numbers)
        {
            IEnumerable<int> query = numbers.Where(s => s % 2 != 0 && s > 5);
            foreach (int n in query)
            {
                Console.WriteLine(n);
            }
        }

        //Find the third smallest number
        private static void find3Smallest(int[] numbers)
        {
            List<int> list = numbers.OrderBy(s => s).ToList();
            Console.WriteLine(list[2]);

        }

        //Calculate sum of all numbers
        private static void calculateSum(int[] numbers)
        {
            IEnumerable<int> num = numbers.Select(s => s);
            int sum = 0;

            foreach (int n in num)
            {
                sum += n;
            }
            Console.WriteLine(sum);

        }

        //Find MAX and MIN
        private static void findMAXnMIN(int[] numbers)
        {
            int num = numbers.Max(s1 => s1);
            int num1 = numbers.Min(s2 => s2);

            Console.WriteLine(num);
            Console.WriteLine(num1);


        }

        //Finding average of the numbers
        private static void findAverage(int[] numbers)
        {
            float num = (float)numbers.Average(s => s);
            Console.WriteLine(num);
        }

        //Printing numbers and their squares
        public static void NumbersnSquares(int[] numbers)
        {
            List<int> squares = numbers.OrderBy(x => x)
                .Select(x => x * x).ToList();

            foreach (int x in squares)
            {
                Console.WriteLine(x);
            }
        }

        // Filter and Sort
        public static void FilternSort(int[] numbers)
        {
            IEnumerable<int> i = numbers.Where(x => x > 3)
                .OrderByDescending(x => x);

            foreach(int a in i)
            {
                Console.WriteLine(a);
            }
                
        }
    }
}