namespace day14_task2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    class program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person {Name="John", Age = 20, City="New York"},
                new Person {Name="Jane", Age = 22, City="London"},
                new Person {Name="Mike", Age = 32, City="New York"},
                new Person {Name="Emily", Age = 41, City="Paris"},
            };
            //Task 1 : Find all the people who live in New York
            List<Person> new_york = people.Where(x => x.City == "New York").ToList();
            //foreach (Person p in new_york)
            //    Console.WriteLine(p.Name);

            //Task 2: Get the names of people older than 30
            List<Person> older = people.Where(x => x.Age > 30).ToList();
            //foreach (Person p in older)
            //    Console.WriteLine(p.Name);

            //Task 3: Sort people by age
            List<Person> age_sort = people.OrderBy(x => x.Age).ToList();
            //foreach (Person p in age_sort)
            //    Console.WriteLine(p.Name);

            //Task 4: Find the oldest person
            Person oldest = people.OrderByDescending(x => x.Age).FirstOrDefault();
            //Console.WriteLine(oldest.Name);

            //Task 5: Group people by City
            var group_city = from p in people
                             group p by p.City into g
                             select new
                             {
                                 City = g.Key,
                                 People = g.ToList()
                             };
            foreach (var v in group_city)
            {
                Console.WriteLine("City:"+v.City);
                foreach(var v2 in v.People)
                {
                    Console.WriteLine("People:" + v2.Name);
                }
            }     

        }
    }
}