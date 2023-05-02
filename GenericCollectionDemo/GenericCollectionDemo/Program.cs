namespace GenericCollectionDemo
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product p1 = new Product() { Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 45000 };
           // Product p2 = new Product() { Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 45000 };
            products.Add(p1);


            List<Product> products1 = new List<Product>();
            {
                new Product() { Id = 2, Name = "Camera", Brand = "Canon", Quantity = 2, Price = 3 };
            }

        }
    }
}`