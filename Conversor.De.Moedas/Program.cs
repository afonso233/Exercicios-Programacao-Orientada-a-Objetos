using Exercicios;
using System.Globalization;
namespace CursoDeProgramador {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dolar?");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Quantos dolares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(quantia, Cotacao);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

