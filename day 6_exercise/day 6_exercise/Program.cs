namespace day6
{
    class program
    {
        void push(ref List<int> stack, int val)
        {
            stack.Add(val);
        }
        int pop(ref List<int> stack)
        {
            int val = stack[]
        }
        public static void Main()
        {

            // Exercise 1
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("Original list");
            foreach (var i in list)
                Console.WriteLine(i);

            list.Remove(2);

            Console.WriteLine("After removing 2");
            foreach (var i in list)
                Console.WriteLine(i);

            list.Add(2);

            Console.WriteLine("After adding 2 again");
            foreach (var i in list)
                Console.WriteLine(i);

            Console.WriteLine("Value is present");

            int flag = 0;

            for(int i=0; i<list.Count; i++)
            {
                if (list[i] == 2)
                    flag = 1;
                break;
            }
            Console.WriteLine(flag);

            // Exercise 2

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];

                if (list[i] < min)
                    min = list[i];
            }

            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);

            // Reverse a list
            List<int> rev = new List<int>();

            for (int i = list.Count-1; i>=0; i--)
            {
                rev.Add(list[i]);
            }

            foreach (var i in rev)
                Console.WriteLine(i);

            //Merge two lists

            List<int> list1 = new List<int>() { 10, 20, 30, 40 };
            List<int> list2 = new List<int>() { 40, 60, 90, 80 };

            List<int> merge = new List<int>();

            foreach (var i in list1)
                merge.Add(i);

            foreach (var i in list2)
                merge.Add(i);

            foreach(var i in merge)
            Console.WriteLine(i);

            // Implement a stack using list
            List<int> stack = new List<int>();
            program ob = new program();
            ob.push(ref stack, 3);
            ob.push(ref stack, 4);
            ob.push(ref stack, 5);
            Console.WriteLine(ob.pop(ref stack));
            foreach (var i in stack) Console.WriteLine(i);
        }
    }
}