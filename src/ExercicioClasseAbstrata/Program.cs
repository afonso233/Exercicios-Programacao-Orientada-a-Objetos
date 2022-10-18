using ExercicioClasseAbstrata.Entidades;
using System.Globalization;

namespace ExercicioClasseAbstrata {
    class Program {
        static void Main(string[] args) {
            List<Contribuinte> listaContribuintes = new List<Contribuinte>();

            Console.Write("Entre com o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int contribuinte = 1; contribuinte <= n; contribuinte++) {
                Console.WriteLine($"Dados do contribuinte #{contribuinte}:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char pessoaFisicaOuJuridica = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Rendimento anual: ");
                double rendimentoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (pessoaFisicaOuJuridica == 'f') {
                    Console.Write("Despesas com saúde: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaContribuintes.Add(new PessoaFisica(nome, rendimentoAnual, gastosComSaude));
                }

                else {
                    Console.Write("Número de empregados: ");
                    int numeroDeEmpregados = int.Parse(Console.ReadLine());
                    listaContribuintes.Add(new PessoaJuridica(nome, rendimentoAnual, numeroDeEmpregados));
                }
                Console.WriteLine();
            }

            double soma = 0.0;
            Console.WriteLine("Impostos pagos: ");
            foreach (var contribuinte in listaContribuintes) {                
                Console.WriteLine(contribuinte.ToString());
                soma += contribuinte.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("Imposto Total: " + "$ " + soma.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}
