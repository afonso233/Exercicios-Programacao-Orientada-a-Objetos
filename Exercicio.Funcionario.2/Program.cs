using Exercicios;
using System.Globalization;
namespace CursoDeProgramador {
    class Program {
        static void Main(string[] args) {

            Funcionario F;
            F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Funcionário: " + F);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + F);


        }
    }
}