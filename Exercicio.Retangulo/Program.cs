using Exercicios;
using System.Globalization;
namespace CursoDeProgramador {
    class Program {
        static void Main(string[] args) {

            Retangulo R;

            R = new Retangulo();

            Console.WriteLine("Entre com a altura e largura do retângulo: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Área = " + R.AreaDoRetangulo().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Perimetro = " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Diagonal = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}