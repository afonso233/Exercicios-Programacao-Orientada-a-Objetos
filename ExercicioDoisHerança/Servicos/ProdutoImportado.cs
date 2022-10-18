using System.Globalization;

namespace ExercicioDoisHerança.Servicos {
    public class ProdutoImportado : Produto {
        public ProdutoImportado(string nome, double preco, double taxaAlfandegaria) : base(nome, preco) {
            TaxaAlfandegaria = taxaAlfandegaria;
        }

        public double TaxaAlfandegaria { get; set; }

        public double PrecoTotal() {
            return Preco + TaxaAlfandegaria;
        }

        public override string EtiquetaDePreco() {
        return Nome 
                + " $ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Taxa Alfandegária: " 
                + "$ " 
                + TaxaAlfandegaria.ToString("f2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
