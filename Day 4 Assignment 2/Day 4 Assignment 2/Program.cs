// See https://aka.ms/new-console-template for more information

namespace Assignment2
{
    class program
    {
        public static void Main()
        {
            //// Code to make each element square
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr2[i] = arr[i] * arr[i];
            }

            for (int j = 0; j <= arr2.Length - 1; j++)
            {
                Console.WriteLine(arr2[j]);
            }

            //Code to reverse an array
            Console.WriteLine("Enter 5 elements of the array:");
            int[] org = new int[5];
            int[] rev = new int[5];
            for (int i = 0; i < 5; i++)
            {
                org[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(org[i]);
                Console.Write("\t");
            }

            Console.WriteLine("\nReversed Array");
            for (int j = 0; j < 5; j++)
            {
                rev[j] = org[5 - j - 1];
                Console.Write(rev[j]);
                Console.Write("\t");
            }

            //Code to remove duplicates from an array
            Console.WriteLine("Enter 8 elements in an array with some duplicates");
            int[] arr = new int[8];
          
            for(int i=0; i<8; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array with duplicates");
            for(int i=0; i < 8; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Array without duplicates");

            HashSet<int> set = new HashSet<int>();  
            for(int i=0; i<8; i++)
            {
                set.Add(arr[i]);
            }
            foreach(int i in set)
            {
                Console.WriteLine(i);
            }

            


        }
    }
}
