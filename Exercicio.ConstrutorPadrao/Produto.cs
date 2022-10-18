using System.Globalization;

namespace Exercicio.ConstrutorPadrao {
    public class Produto {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return 
                 Nome
                + ", "
                + "$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                +Quantidade
                +" unidades"
                +", "
                +"total: "
                +"$ "
                +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
