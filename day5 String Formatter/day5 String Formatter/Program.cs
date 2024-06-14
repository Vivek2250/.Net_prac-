class program
{
    class StringFormatter
    {
        public string Format(string str)
        {
            string str1 = str.ToUpper();
            return str1;
        }

        public string Format(string str, int x)
        {
            string str1 = "";
            for(int i=1; i<=x; i++)
            {
                str1 += str;
;           }
            return str1;
        }

        public string Format(string str1, string str2)
        {
            string str = str1 + " " + str2;
            return str;
        }
    }

    public static void Main()
    {
        StringFormatter str1 = new StringFormatter();
        Console.WriteLine(str1.Format("hello"));

        StringFormatter str2 = new StringFormatter();
        Console.WriteLine(str2.Format("hello", 4));

        StringFormatter str3 = new StringFormatter();
        Console.WriteLine(str3.Format("hello", "world"));

    }
}