namespace Linq_Practice1
{
    public class Employee
    {
            public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int Age { get; set; }

    }
    class program
    {
       public static void Main(string[] args)
        {
            Employee[] EmployeeArray =
            {
                new Employee() {EmployeeId = 1, EmployeeName = "Ram", Age= 13 },
                new Employee() {EmployeeId = 2, EmployeeName = "Raman", Age= 17 },
                new Employee() {EmployeeId = 3, EmployeeName = "Rahul", Age= 23 },
                new Employee() {EmployeeId = 4, EmployeeName = "Ramakant", Age= 19 },
                new Employee() {EmployeeId = 5, EmployeeName = "Ramu", Age= 20 },
                new Employee() {EmployeeId = 6, EmployeeName = "Ramya", Age= 16 },
                new Employee() {EmployeeId = 7, EmployeeName = "Ramesh", Age= 2 },
            };

            //// Using traditional method
            //Employee[] Employees = new Employee[10];
            //int i = 0;

            //foreach(Employee emp in EmployeeArray)
            //{
            //    if(emp.Age >12 && emp.Age < 20)
            //    {
            //        Employees[i] = emp;
            //        System.Console.WriteLine(emp.EmployeeName);
            //        i++;
            //    }
            //}

            // Using Lambda Expressions
            //Employee[] employees = EmployeeArray.Where(s=> s.Age>12 && s.Age<20).ToArray();

            //foreach (var emp in employees)
            //    Console.WriteLine(emp.EmployeeName);

            //Names sorting
            var sortedByName = EmployeeArray.OrderBy(s => s.EmployeeName);
            foreach (var emp in sortedByName)
                Console.WriteLine(emp.EmployeeName);

            //Names starting with R
            var nameWithR = EmployeeArray.Where(s => s.EmployeeName.StartsWith("R"));
            foreach (var emp in nameWithR)
                Console.WriteLine(emp.EmployeeName);

            //Oldest Employee
            var oldest = EmployeeArray.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine(oldest.EmployeeName);

            //Average Age
            var average = EmployeeArray.Average(s => s.Age);
            Console.WriteLine(average);

        }
    }
}