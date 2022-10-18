using Exercicio.ContasBancarias.Servico;
using System.Globalization;

namespace Exercicio.ContasBancarias {
    class Program {
        static void Main(string[] args) {

            ContaBancaria contaBancaria;
            
            Console.Write("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char escolhaDepositoOuNao = char.Parse(Console.ReadLine());

            if (escolhaDepositoOuNao == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
                contaBancaria = new ContaBancaria(numeroDaConta, titular, depositoInicial);
            }
            else {                             
                contaBancaria = new ContaBancaria(numeroDaConta, titular);               
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);
            
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado: ");            
            Console.WriteLine(contaBancaria);

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(saque);
            Console.WriteLine("Dados da conta atualizado: ");            
            Console.WriteLine(contaBancaria);

            Console.ReadKey();
        }
    }
}