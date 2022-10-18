using System.Globalization;

namespace Exercicio.ContasBancarias.Servico {
    public class ContaBancaria {

        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string titular) {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroDaConta, string titular, double saldo) : this(numeroDaConta, titular) {
            Saldo = saldo;
        }



        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "conta "
                + NumeroDaConta
                + ", "
                + "Titular: "
                + Titular
                + ", "
                + "Saldo: "
                + " $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}