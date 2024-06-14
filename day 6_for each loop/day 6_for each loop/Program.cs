namespace ForEach
{
    class program
    {
        public static void Main()
        {
            //List<int> intList = new List<int>() { 10, 20, 30, 40 };
            ////intList.Add(10);
            ////intList.Add(20);
            ////intList.Add(30);

            //intList.Remove(20);
            //intList.RemoveAt(2);


            /////*fo*/r (int i = 0; i < intList.Count; i++)
            //////{
            ////Console.WriteLine(intList[i]);
            //////}

            //foreach(var x in intList)
            //{
            //Console.WriteLine(x);
            //}

            //intList.ForEach(x => Console.WriteLine(x));

            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("five");

            for(int i=0; i<strList.Count; i++)
            {
                Console.WriteLine(strList[i]);
            }

            foreach(var x in strList)
            {
                Console.WriteLine(x);
            }

        }
        
    }
}
