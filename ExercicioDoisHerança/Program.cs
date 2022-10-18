using ExercicioDoisHerança.Servicos;
using System.Globalization;


namespace ExercicioDoisHerança {
    class program {
        static void Main(string[] args) {
            List<Produto> listaProdutos = new List<Produto>();
            
            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int prod = 1; prod <= n; prod++) {
                Console.WriteLine($"Dados do produto #{prod}:");
                Console.Write("Comun, usado ou importado (c/u/i)?");
                char escolhaDoProduto = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(escolhaDoProduto=='c') {
                    listaProdutos.Add(new Produto(nome, preco));
                }
                
                else if (escolhaDoProduto == 'u') {
                    Console.Write("Data de fabricação (DD/MM/YYY): ");
                    DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine()); 
                    listaProdutos.Add(new ProdutoUsado(nome, preco, dataDeFabricacao));
                }
                else{
                    Console.Write("Taxa Alfandegária: ");
                    double taxaAlfandegaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaProdutos.Add(new ProdutoImportado(nome, preco, taxaAlfandegaria));
                }
                
                
                Console.WriteLine();
            }

            Console.WriteLine("Etiquetas de preço:");
            foreach (var produto in listaProdutos) {
                Console.WriteLine(produto.EtiquetaDePreco());
            }

            Console.ReadKey();
        }
    }
}