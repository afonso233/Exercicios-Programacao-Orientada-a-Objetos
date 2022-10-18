namespace ExercicioClasseAbstrata.Entidades {
    public class PessoaFisica : Contribuinte {
        
        public PessoaFisica(string nome, double rendimentoAnual, double gastosComSaude) : base(nome, rendimentoAnual) {
            GastosComSaude = gastosComSaude;
        }

        public double GastosComSaude { get; set; }
        
        public override double Tax() {
             if(RendimentoAnual < 20000.0) {
                return RendimentoAnual * 0.15 - GastosComSaude * 0.5;
            }
            else {
                return RendimentoAnual * 0.25 - GastosComSaude * 0.5;
            }
        }
    }
}
