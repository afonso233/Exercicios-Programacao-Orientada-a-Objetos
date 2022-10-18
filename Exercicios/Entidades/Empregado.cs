using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Entidades {
    public class Empregado {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        

        public Empregado(string nome, int horas, double valorPorHora) {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento() {
            return Horas * ValorPorHora;
        }

        public override string ToString() {
            return Nome + " - " + "$ " + Pagamento().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
