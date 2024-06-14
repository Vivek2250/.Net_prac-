// See https://aka.ms/new-console-template for more information
using Demo2;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    public static void Main()
    {
        //If else statement

        /*string name = "bankai";

        if(name == "rengoku")
            Console.WriteLine("flame breathing");
     
        else
                Console.WriteLine(name);    
        
        // Nested if else statement

        int i = 20;
        if (i == 10)
            Console.WriteLine("i is 10");

        else if (i == 15)
            Console.WriteLine("i is 15");

        else if (i == 20)
            Console.WriteLine("i is 20");

        else
            Console.WriteLine("i is not present");

        // Switch case ststement 

        int number = 50;
        switch (number)
        {
            case 10:
                Console.WriteLine("number is 10");
                break;

            case 30:
                Console.WriteLine("number is 30");
                break;

            case 50:
                Console.WriteLine("number is 50");
                break;

            default:
                Console.WriteLine("number does not match");
                break;

        }

        //Switch case with goto statements

        int greeting = 2;
        switch(greeting)
        {
            case 1:
                Console.WriteLine("Hello!");
                goto default;

            case 2:
                Console.WriteLine("Bonjour!");
                goto case 3;

            case 3:
                Console.WriteLine("Namaste!");
                goto default;

            default:
                Console.WriteLine("The value is: " + greeting);
                break;
        }

        //while loop 

        int x = 1;
        while (x <= 4)
        {
            Console.WriteLine(x);
            x++;
        }

        //for loop 

        for(int i=0; i<=4; i++) {
            Console.WriteLine(i);
        }

        //Array problem 

        int[] arr = new int[20];
            for(int i=0; i<20; i++)
        {
            arr[i] = i+1;
        }
        for(int i=0; i<20; i++)
        {
            if (arr[i]%2 == 0)
                Console.WriteLine(arr[i]+ " is even");

            else
                Console.WriteLine(arr[i] + " is odd");
        }
        

        //Count number of letters and words

        int words = 1;
        int letters = 0;
        string msg = "She Sells Sea Shells on a Sea Shore";
            for(int i=0; i<msg.Length; i++) {
            if (msg[i]>='A' && msg[i]<='Z' || msg[i]>='a' && msg[i] <= 'z')
                  letters++;
            if (msg[i] == ' ')
                words++; 
        }
            Console.WriteLine("Number of letters: "+letters);
            Console.WriteLine("Number of words: "+words);
        Console.WriteLine(msg.Split(' ').Length); 

        //Calling a method

        int sum = add(2, 3);
        int diff = sub(9, 4);
        int pdt = mul(4, 8);
        double qnt = div(10, 3);
        Console.WriteLine("Sum is: "+sum);
        Console.WriteLine("Diff is: " + diff);
        Console.WriteLine("product is: " + pdt);
        Console.WriteLine("qoutient is: " + qnt);

        static int add(int a, int b)
        {
            return a + b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static double div(int a, int b)
        {
            return (double)a / b;
        }

        Employee emp = new Employee();
        emp.PrintFirstName();
        emp.PrintLastName();

        Department dept = new Department();
        dept.DeptName();
        dept.DeptLoc();

        // Calculator Class code
        
        int a, b;
        int option;
        Console.WriteLine("Enter two numbers");
        a =Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose your option:\n 1) Add\n 2) Subtract\n 3) Multiply\n 4) Division\n");
        option= Convert.ToInt32(Console.ReadLine());

        Calculator cal = new Calculator();

        switch (option)
        {
            case 1: cal.Add(a, b);
                break;
            case 2: cal.Sub(a, b);
                break;
            case 3: cal.Mul(a, b);
                break;
            case 4: cal.Div(a, b);
                break;

        } 

        
        // Code to reverse a string
        Console.WriteLine("Original string: ");
        string str = Console.ReadLine();
        string rev = string.Empty;

        for(int i = str.Length-1; i>=0; i--)
        {
            rev += str[i];
        }
        Console.WriteLine("Reverse string: " + rev);


        // Code to swap the name
        Console.WriteLine("Enter you name: ");
        string name = Console.ReadLine();
        string[] s = name.Split(' ');
        string s1 = s[1] + " " + s[0];
        Console.WriteLine("Swapped name: " + s1);




       //Code to find the name as palindrome
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string rev = string.Empty;

        for(int i=str.Length-1; i>=0; i--)
        {
            rev += str[i];
        }
        if (rev.Equals(str))
        {
            Console.WriteLine("String is palindrome");
        }
        else
        {
            Console.WriteLine("String is not palindrome");
        } 

        //Sting to separate country code
        Console.WriteLine("Enter your phone number with country code: ");
        string phn = Console.ReadLine();
        string format = phn.Substring(0,3)+ " "+ phn.Substring(3);
        Console.WriteLine("Phone Number in format is: "+format);
         
        */

        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=10; i++)
        {
            int mul = n * i;
            Console.WriteLine(mul);
        }





        
        
    }
}
