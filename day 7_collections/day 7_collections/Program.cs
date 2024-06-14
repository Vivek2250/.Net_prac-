using System.Collections;

namespace collections
{
    class program
    {
        public static void Main()
        {
            //Queue queue = new Queue();
            //queue.Enqueue(4);
            //queue.Enqueue(6);
            //queue.Enqueue(7);
            //queue.Enqueue("Rengoku");

            //Console.WriteLine("After adding elements: "+queue.Count);

            //while (queue.Count > 0)
            //{
            //Console.WriteLine(queue.Dequeue());
            //}

            //Console.WriteLine("After removing elements: " + queue.Count);

            //Stack stack = new Stack();
            //stack.Push(12);
            //stack.Push(13);
            //stack.Push(33);
            //stack.Push("Rengoku");
            //stack.Push("Kyojuro");

            //foreach (var i in stack)
            //    Console.WriteLine(i);

            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add("var", "three");
            ht.Add(4.2f, 9.6f);
            ht.Add("var1", "hundred");
            ht.Add(3.4f, 99.87f);

            //foreach (DictionaryEntry i in ht)
            //    Console.WriteLine(i.Key + " = "+ i.Value);

            foreach (var i in ht)
                Console.WriteLine(i);

            //string s1 = (string)ht[1];
            //string s2 = (string)ht[2];
            //string s3 = (string)ht["var"];
            //float f = (float)ht[4.2f];

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(f);


        }
    }
}