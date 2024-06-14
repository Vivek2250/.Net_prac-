namespace day13_practice1
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = 1, Name = "John Doe", City = "New York" },
                new Customer { CustomerID = 2, Name = "Jane Smith", City = "Los Angeles" },
                new Customer { CustomerID = 3, Name = "Emily Johnson", City = "Chicago" }
            };

            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2023, 1, 20), Amount = 250.00m },
                new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2023, 1, 22), Amount = 75.00m },
                new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2023, 1, 25), Amount = 125.00m },
                new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2023, 2, 1), Amount = 200.00m }
            };

            //Task 1: Find all orders for a specific customer
            var result = from c in customers
                         join o in orders
                         on c.CustomerID equals o.CustomerID
                         where c.Name == "John Doe"
                         select new
                         {
                             OrderId = o.OrderID,
                             CustomerId = o.CustomerID,
                             Orderdate = o.OrderDate,
                             Amount1 = o.Amount
                         };

            foreach (var v in result)
                Console.WriteLine($"Order Id: {v.OrderId}, Customer Id: {v.CustomerId}, Order Date: {v.Orderdate}, Amount: {v.Amount1}");

            //Task 2: Calculate total sales by city
            var sales = from c in customers
                        join o in orders
                        on c.CustomerID equals o.CustomerID
                        group o.Amount by c.City into g
                        select new
                        {
                            City = g.Key,
                            Sales = g.Sum()
                        };

            foreach (var v in sales)
                Console.WriteLine($"City: {v.City}, Total Sales: {v.Sales}");

            //Task 3: List Customers with no Orders
            var no_Orders = from c in customers
                            join o in orders
                            on c.CustomerID equals o.CustomerID into jointable
                            from p in jointable.DefaultIfEmpty()
                            where p == null
                            select new
                            {
                                Customers = c.Name,
                                City = c.City
                            };
            foreach (var order in no_Orders)
                Console.WriteLine($"Customer Name: {order.Customers}, City: {order.City}");

            //Task 4: Most recent order for each customer
            var recent = from c in customers
                         select new
                         {
                             CustomerId = c.CustomerID,
                             Order = orders.Where(x => x.CustomerID == c.CustomerID).OrderByDescending(x => x.OrderDate).FirstOrDefault()
                         };


            foreach (var rec in recent)
                Console.WriteLine($"Customer ID: {rec.CustomerId}, Most recent order order ID: {rec.Order.OrderID}, Order Date:{rec.Order.OrderDate.ToShortDateString()}, Amount: {rec.Order.Amount}");
        }
    }
}