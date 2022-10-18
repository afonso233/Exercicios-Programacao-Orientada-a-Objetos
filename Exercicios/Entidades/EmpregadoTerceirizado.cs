using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Entidades {
    public class EmpregadoTerceirizado : Empregado {

        public EmpregadoTerceirizado(string nome, int horas, double valorPorHora, double valorAdicional) 
            : base(nome, horas, valorPorHora) {
      
            ValorAdicional = valorAdicional;
        }

               
        public double ValorAdicional { get; set; }

        public override double Pagamento() {
            return base.Pagamento() + ValorAdicional * 1.1;
        }
    
    }
} 

