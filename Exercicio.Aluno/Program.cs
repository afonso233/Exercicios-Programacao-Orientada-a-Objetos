using Exercicios;
using System.Globalization;
namespace CursoDeProgramador {
    class Program {
        static void Main(string[] args) {

            Aluno A;
            A = new Aluno();

            Console.Write("Nome do aluno:");
            A.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite as trê notas do aluno: ");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota final = " + A.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            if (A.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + A.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}

