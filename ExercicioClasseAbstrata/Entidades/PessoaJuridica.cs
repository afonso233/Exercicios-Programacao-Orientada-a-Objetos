using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrata.Entidades {
    public class PessoaJuridica : Contribuinte {
        
        public PessoaJuridica(string nome, double rendimentoAnual, int numeroDeEmpregados) : base(nome, rendimentoAnual) {
            NumeroDeEmpregados = numeroDeEmpregados;
        }

        public int NumeroDeEmpregados { get; set; }

        public override double Tax() {
            if (NumeroDeEmpregados > 10) {
                return RendimentoAnual * 0.14;
            }
            else {
                return RendimentoAnual * 0.16;
            }
        }
    }
}
