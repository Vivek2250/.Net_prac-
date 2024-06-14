using System.Collections;

namespace arraylist
{
    class program
    {
        public static void Main()
        {
            //ArrayList myList = new ArrayList();
            //myList.Add(10);
            //myList.Add("Ram");
            //myList.Add(56.4f);

            //foreach(var x in myList)
            //{
                //Console.WriteLine(x);
            //}

            SortedList sortedList1 = new SortedList();
            sortedList1.Add(4, "Four");
            sortedList1.Add(3, "Three");
            sortedList1.Add(1, "One");
            sortedList1.Add(2, "Two");
            sortedList1.Add(5, "Five");

            //foreach(DictionaryEntry pair in sortedList1)
            //{
            //    Console.WriteLine(pair.Value);
            //}

            for(int i=0; i<sortedList1.Count; i++)
            {
                Console.WriteLine(sortedList1.GetByIndex(i));
            }

        }
    }
}