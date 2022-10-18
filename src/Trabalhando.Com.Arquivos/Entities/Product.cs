namespace Exercicios.Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantify { get; set; }

        public Product(string name, double price, int quantify) {
            Name = name;
            Price = price;
            Quantify = quantify;
        }

        public double Total() {
            return Price * Quantify;
        }
    }
}
