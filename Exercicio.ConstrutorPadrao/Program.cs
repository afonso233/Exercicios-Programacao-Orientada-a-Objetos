using Exercicio.ConstrutorPadrao;
using System.Globalization;

namespace exercicioConstrutorPadrao {
    class Program {
        static void Main(string[] args) {
            Produto produto = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome= Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
           Console.WriteLine();
           
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int addQuantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(addQuantidade);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            int removeQuantidade = int.Parse(Console.ReadLine());
            produto.RemoverProduto(removeQuantidade);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

            Console.ReadKey();
        }
    }
}