// See https://aka.ms/new-console-template for more information
namespace Assignment
{
    class Department
    {
        public string DeptName;
        public string DeptLoc;
        
        public void GetDeptName()
        {
            Console.WriteLine("My Department Name is: " + DeptName);
        }
        public void GetDeptLoc()
        {
                Console.WriteLine("My department location is: " + DeptLoc);
            }
        }

        class Employee: Department
        {
            public void GetFirstName()
            {
                Console.WriteLine("My First name is Vivek");
            }
            public void GetLastname()
            {
                Console.WriteLine("My last name is Kumar");
            }
        }

        class program
        {
            public static void Main()
            {
                Employee emp = new Employee();
                emp.DeptName = "Consulting";
                emp.DeptLoc = "Kolkata";
                emp.GetFirstName();
                emp.GetLastname();
                emp.GetDeptLoc();
                emp.GetDeptLoc() ;

                Console.ReadLine();
            }
        }
}
