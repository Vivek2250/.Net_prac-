namespace day12_task2
{
    public class Product
    {
        public int ProductID { get; set;}
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
    new Product() { ProductID = 1, Name = "Apple", Category = "Fruits", Price = 1.00f},
    new Product() { ProductID = 2, Name = "Milk", Category = "Dairy", Price = 0.99f },
    new Product() { ProductID = 3, Name = "Cheese", Category = "Dairy", Price = 2.50f },
    new Product() { ProductID = 4, Name = "Banana", Category ="Fruits", Price=0.50f},
    new Product(){ ProductID = 5, Name="Yogurt", Category="Dairy", Price=1.50f}

            };

            //Find all Dairy Products
            List<Product> product = products.Where(s => s.Category == "Dairy").ToList();

            foreach (var v in product)
                Console.WriteLine(v.Name);

            //Sort products by price
            List<Product> product1 = products.OrderByDescending(x => x.Price).ToList();

            foreach (var v in product1)
                Console.WriteLine(v.Name);

            //Get the most expensive product
            Product product2 = products.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine(product2.Name);

            //Calculate total price of the fruits
            float p3 = products.Where(x => x.Category == "Fruits").Sum(p => p.Price);
            Console.WriteLine(p3);

            //List product with price formatted as currency
            foreach (Product pdt in products)
            {
                Console.WriteLine($"{pdt.Name} = ${pdt.Price}");
            }

            //Products cheaper than $1.00
            List<Product> product4 = products.Where(s => s.Price < 1.00).ToList();

            foreach (var x in product4)
                Console.WriteLine(x.Name);

            //Group products by category
            List<Product> product5 = products.OrderBy(x=>x.Category).ToList();

            foreach (var v in product5)
                Console.WriteLine($"{v.Name} = {v.Category}");


        }
    }
}