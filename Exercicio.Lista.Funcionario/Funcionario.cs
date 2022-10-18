using System.Globalization;
namespace Exercicios {
    class Funcionario {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string name, double salario) {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentoDeSalario(double porcentagem) {
            Salario = Salario + Salario * porcentagem / 100;
        }

        public override string ToString() {
            return Id + ", " + Name + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}