namespace day13_task2
{
    class program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = Enumerable.Range(1, 1000).Select(_ => random.Next(1, 1001)).ToArray();

            //Task 1: Find average
            double average = numbers.Average();
            Console.WriteLine("Average of numbers: "+average);

            //Task 2: Find maximum
            int maximum = numbers.Max();
            Console.WriteLine("Maximum number: "+maximum);

            //Task 3: Find minimum
            int minimum = numbers.Min();
            Console.WriteLine("Minimum number: "+minimum);

            //Task 4: Count even numbers
            int count_even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine("Count of even numbers: "+count_even);

            //Task 5: Sum of odd numbers
            int sum_odd = numbers.Where(x => x % 2 != 0).Sum();
            Console.WriteLine("Sum of odd numbers: "+sum_odd);

            //Task 6: List top 10 highest values
            IEnumerable<int> top = numbers.OrderByDescending(x => x).Take(10);
            foreach (int i in top)
                Console.WriteLine("List of top 10 highest numbers: "+i);

            //Task 7: Find all unique numbers
            IEnumerable<int> unique = numbers.Select(x => x).Distinct();
            foreach (int i in unique)
                Console.WriteLine("Unique numbers: "+i);

            //Task 8: Group numbers by even and odd
            var even_odd = from num in numbers
                           group num by num % 2 == 0 into gs
                           select new
                           {
                               Title = gs.Key ? "Even" : "Odd",
                               Value = gs.Count(num => gs.Key ? num % 2 == 0 : num % 2 != 0),
                           };

            foreach (var v in even_odd)
                Console.WriteLine("Count of even and odd numbers: "+v.Title + " " + v.Value);

            //Task 9: Calculate Median
            List<int> list = numbers.OrderBy(x => x).ToList();
            int n = list.Count() / 2;
            double median = (list[n/2] + list[ (n / 2) + 1] ) / 2;
            Console.WriteLine("Median: "+median);

            //Task 10: Sum of numbers greater than 500
            int greater_sum = numbers.Where(x => x > 500).Sum();
            Console.WriteLine("Sum of numbers greater tha 500: " + greater_sum);
        }
    }
}