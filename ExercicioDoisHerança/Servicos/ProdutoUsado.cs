namespace ExercicioDoisHerança.Servicos {
    public class ProdutoUsado : Produto {
        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco) {
            DataDeFabricacao = dataDeFabricacao;
        }
        
        public DateTime DataDeFabricacao { get; set; }

        public override string EtiquetaDePreco() {
            return Nome 
                + " (usado) " 
                +  "$ " 
                + Preco  
                + " (Data de fabricação: " 
                + DataDeFabricacao.ToString("dd/MM/yyy") 
                + ")";
        }
    }
}
