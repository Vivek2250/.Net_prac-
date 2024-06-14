namespace day24_task1_employee.Models
{
    public interface IEmployeeDetails
    {
        public List<Employee> GetEmployees();
    }

    public class EmployeeDetails : IEmployeeDetails
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Title = "Mr",
                    Name = "Simon",
                    Age = 32,
                    EmailId = "simon@gmail.com",
                    MobileNumber = 123234,
                    Address = "Pune",
                    PinCode = 23454
                },
                new Employee()
                {
                    Id=2,
                    Name = "David",
                    Age = 35,
                    EmailId = "david@gmail.com",
                    MobileNumber = 87654,
                    Address = "Mumbai",
                    PinCode = 76345
                },
                new Employee()
                {
                    Id=1,
                    Title = "Mr",
                    Name = "Peter",
                    Age = 49,
                    EmailId = "peter@gmail.com",
                    MobileNumber = 1203498,
                    Address = "Kolkata",
                    PinCode = 21345
                }
            };
            return employees;
        }
    }
}
