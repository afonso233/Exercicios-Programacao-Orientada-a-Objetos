using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrata.Entidades {
    public abstract class Contribuinte {
        public string Nome { get; set; }
        public double RendimentoAnual { get; set; }

        public Contribuinte() {
        }

        public Contribuinte(string nome, double rendimentoAnual) {
            Nome = nome;
            RendimentoAnual = rendimentoAnual;
        }

        public abstract double Tax();

        public override string ToString() {
            return Nome
                + ": "
                + "$ "
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
