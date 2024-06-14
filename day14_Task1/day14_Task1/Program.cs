using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace day14_task1
{
    public class Employee
    {
        public int EmployeeID {  get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public List<int> ProjectIDs { get; set; }   
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }

    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
    }
    
    class program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee { EmployeeID = 101, Name = "John Doe", DepartmentID = 1, ProjectIDs = new List<int> { 101, 102, 103 } },
            new Employee { EmployeeID = 102, Name = "Jane Smith", DepartmentID = 2, ProjectIDs = new List<int> { 104, 105 } },
            new Employee { EmployeeID = 103, Name = "Robert Johnson", DepartmentID = 1, ProjectIDs = new List<int> { 106 } },
            new Employee { EmployeeID = 104, Name = "Emily Brown", DepartmentID = 3, ProjectIDs = new List<int> { 107, 108 } },
            new Employee { EmployeeID = 105, Name = "Michael Lee", DepartmentID = 2, ProjectIDs = new List<int> { 109 } }
            };

            List<Department> departments = new List<Department>()
            {
            new Department { DepartmentID = 1, Name = "Sales" },
            new Department { DepartmentID = 2, Name = "Marketing" },
            new Department { DepartmentID = 3, Name = "Engineering" },
            new Department { DepartmentID = 4, Name = "Finance" },
            new Department { DepartmentID = 5, Name = "Human Resources" }
            };

            List<Project> projects = new List<Project>()
            {
            new Project { ProjectID = 101, Title = "Product Launch" },
            new Project { ProjectID = 102, Title = "Inventory Management" },
            new Project { ProjectID = 103, Title = "Website Redesign" },
            new Project { ProjectID = 104, Title = "Market Research" },
            new Project { ProjectID = 105, Title = "Social Media Campaign" }
            };

            //Task 1: List employees in each department
            var emp_dept = from emp in employees
                           join dept in departments
                           on emp.DepartmentID equals dept.DepartmentID
                           group emp by dept.DepartmentID into g
                           select new
                           { 
                              Name = departments.Where(x=>x.DepartmentID==g.Key).First().Name,
                              employee = employees.Where(x=>x.DepartmentID==g.Key)
                           };
            //foreach (var dept in emp_dept)
            //{
            //    Console.WriteLine(dept.Name);
            //    foreach (var emp in dept.employee)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }
            //}

            //Task 2: Find employee without project
            var no_project = from e in employees
                             where !e.ProjectIDs.Any(v=>projects.Any(x => x.ProjectID == v))
                             select e;

            //foreach (var emp in no_project)
            //    Console.WriteLine(emp.Name);

            //Task 3: Counnt employees in each project
            var emp_proj = from p in projects
                        select new
                        {
                            Name = p.Title,
                            Count = employees.Where(x => x.ProjectIDs.Contains(p.ProjectID)).Count()
                        };
            //foreach (var v in emp_proj)
            //    Console.WriteLine(v.Name + " has " + v.Count + " people");

            //Task 4: Find projects with more than 3 employees
            var proj = (from p in projects
                       select new
                       {
                           Name = p.Title,
                           Count = employees.Where(x => x.ProjectIDs.Contains(p.ProjectID)).Count(),
                       }).Where(x => x.Count > 3);

            foreach (var v in proj)
                Console.WriteLine(v.Name);
        }
    }
}