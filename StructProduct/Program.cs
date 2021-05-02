using System;

namespace StructProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "mouse gamer", 299.97, EProductType.Product);
            // Product mouse = new Product(1, "mouse gamer", 299.97);

            var manutenção = new Product(2, "manutenção", 150.00, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);

            Console.WriteLine((int)manutenção.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public EProductType Type { get; set; }

        public double PriceInDolar(double price, double dolar)
        {
            return price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
