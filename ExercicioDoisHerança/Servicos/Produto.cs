using System.Globalization;

namespace ExercicioDoisHerança.Servicos {
    public class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public virtual string EtiquetaDePreco() {
        return Nome 
                + " $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        }
    }

