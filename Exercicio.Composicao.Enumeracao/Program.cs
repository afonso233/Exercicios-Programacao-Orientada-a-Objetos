namespace Exercicios;
using Exercicios.Entities;
using Exercicios.Entities.Enums;
using System.Globalization;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter cliente data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data:");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Client client = new Client(name, email, birthdate);
        Order order = new Order(DateTime.Now, status, client);


        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Product product = new Product(productName, price);

            Console.Write("Quantify: ");
            int quantify = int.Parse(Console.ReadLine());
            OrderItem item = new OrderItem(quantify, price, product);

            order.Items.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine("ORDER SUMMARY:");
        Console.WriteLine(order);

    }
}