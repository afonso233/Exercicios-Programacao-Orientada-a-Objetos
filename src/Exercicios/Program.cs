using Exercicios.Entidades;
using System.Globalization;
using System.Runtime.Serialization;

namespace ExercicioHenrança {
    class Program {
        static void Main(string[] args) {
            List<Empregado> listaEmpregados = new List<Empregado>();

            Console.Write("Entre com o número de empregados: ");
            int n = int.Parse(Console.ReadLine());

            for (int emp = 1; emp <= n; emp++) {
                Console.WriteLine($"Empregado #{emp} dados: ");
                Console.Write("Terceirizado (s/n)? ");
                char terceirizado = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (terceirizado == 's') {
                    Console.Write("Valor adicional: ");
                    double valorAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    listaEmpregados.Add(new EmpregadoTerceirizado(nome, horas, valorPorHora, valorAdicional));

                }

                else {
                    
                    listaEmpregados.Add(new Empregado(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine("Pagamentos: ");
            foreach (Empregado empregado in listaEmpregados) {
                Console.WriteLine(empregado);
            }
           
            Console.ReadKey();

        }
    }
}





