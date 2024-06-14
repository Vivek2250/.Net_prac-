using System.Collections;

namespace collections
{
    class program
    {
        public static void Main()
        {
            // Task 1
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var x in list)
                Console.WriteLine(x);

            list.Remove(5);
            list.Remove(4);
            list.Remove(3);

            Console.Write("\n");

            foreach (int i in list)
                Console.WriteLine(i);

            int flag = 0;
            int search = 3;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == search)
                    flag = 1;
                    break;
            }
            Console.Write("\n");
            Console.WriteLine(flag);
            Console.Write("\n");

            // Task 2
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");

            foreach(string s in queue)
            Console.WriteLine(s);
            Console.Write("\n");

            queue.Dequeue();

            foreach (string s in queue)
                Console.WriteLine(s);
            Console.Write("\n");

            Console.WriteLine(queue.Peek());
            Console.Write("\n");

            int flag1 = 0;
            foreach(string s in queue)
            {
                if (s.Equals("three"))
                    flag1 = 1;
            }

            Console.WriteLine(flag1);
            Console.Write("\n");


            // Task 3
            Stack<double> stack = new Stack<double>();
            stack.Push(1.1);
            stack.Push(2.2);
            stack.Push(3.3);
            stack.Push(4.4);
            stack.Push(5.5);

            foreach (double d in stack)
                Console.WriteLine(d);
            Console.Write("\n");

            stack.Pop();

            foreach(double d in stack)
                Console.WriteLine(d);
            Console.Write("\n");

            Console.WriteLine(stack.Peek());
            Console.Write("\n");

            int flag2 = 0;

            if (stack.Contains(2.2))
                flag2 = 1;

            Console.WriteLine(flag2);
            Console.Write("\n");

            // Task 4
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add("rengoku");
            arraylist.Add("ichigo");
            arraylist.Add(new DateTime());

            foreach (var x in arraylist)
                Console.WriteLine(x);
            Console.Write("\n");

            arraylist.RemoveAt(1);

            foreach (var x in arraylist)
                Console.WriteLine(x);
            Console.Write("\n");

            int count = 0;
            foreach (var x in arraylist)
            {
                if (x == "rengoku")
                    break;
                else
                    count++;
            }
            

            Console.WriteLine("Index: " +count);
            Console.Write("\n");

            // For strongly typed array
            int[] array1 = arraylist.OfType<int>().ToArray();

            foreach(int x in array1)
                Console.WriteLine(x);
            Console.Write("\n");

            string[] array2 = arraylist.OfType<String>().ToArray();

            foreach (string s in array2)
                Console.WriteLine(s);
            Console.Write("\n");

            DateTime[] array3 = arraylist.OfType<DateTime>().ToArray();

            foreach (DateTime x in array3)
                Console.WriteLine(x);

        }
    }
}