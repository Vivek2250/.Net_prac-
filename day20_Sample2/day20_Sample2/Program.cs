using day20_Sample2;

namespace day20
{
    class program
    {
        public static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                Console.WriteLine("Employee Table");
                List<TblEmployee> employees = context.TblEmployees.ToList();
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Employee Id: {employee.Id}, Employee name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}, City: {employee.City}");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Gender Table");
                List<TblGender> genders = context.TblGenders.ToList();
                foreach(var gender in genders)
                {
                    Console.WriteLine($"Gender Id: {gender.Id}, Gender: {gender.Gender}");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Person Table");
                List<TblPerson> person = context.TblPeople.ToList();
                foreach(var people in person)
                {
                    Console.WriteLine($"Id: {people.Id}, Email: {people.Email}, Gender Id: {people.GenderId}");
                }
            }
        }
    }
}