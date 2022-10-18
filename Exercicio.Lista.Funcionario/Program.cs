using Exercicios;
using System.Globalization;
namespace System.Collections.Generic;
class Program {
    static void Main(string[] args) {


        Console.Write("Quantos funcionarios serão cadastrados? ");
        int n = int.Parse(Console.ReadLine());

        List<Funcionario> list = new List<Funcionario>();

        for (int i = 1; i <= n; i++) {
            Console.WriteLine($"Funcionários #[{i}]: ");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            list.Add(new Funcionario(id, nome, salario));

            Console.WriteLine();
        }

        Console.Write("Insira o ID do funcionário que terá aumento salarial: ");
        int procurarId = int.Parse(Console.ReadLine());

        Funcionario aumentoDeSalario = list.Find(x => x.Id == procurarId);
        if (aumentoDeSalario != null) {
            Console.Write("Digite a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aumentoDeSalario.AumentoDeSalario(porcentagem);
        }

        else {
            Console.WriteLine("Esse ID não existe!");
        }

        Console.WriteLine();
        Console.WriteLine("Lista atualizada de funcionários: ");
        foreach (Funcionario obj in list) {
            Console.WriteLine(obj);
        }
    }

}



