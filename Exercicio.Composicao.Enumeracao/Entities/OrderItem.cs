using System.Globalization;
namespace Exercicios.Entities {
    class OrderItem {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() {

        }

        public OrderItem(int quantify, double price, Product product) {
            Quantify = quantify;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Quantify * Price;
        }
        public override string ToString() {
            return Product.Name
                + ", "
                + "$" + Price
                + ", "
                + "Quantify: " + Quantify
                + ", "
                + "Subtotal: "
                + "$"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
