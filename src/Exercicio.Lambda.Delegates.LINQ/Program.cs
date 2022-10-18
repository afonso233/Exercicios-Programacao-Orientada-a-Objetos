using Exercicios.Entidade;
using System.Globalization;
namespace Exercicios {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter full file path: ");
            string caminho = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Funcionario> lista = new List<Funcionario>();

            try {
                using (StreamReader sr = File.OpenText(caminho)) {
                    while (!sr.EndOfStream) {
                        string[] campos = sr.ReadLine().Split(',');
                        string nome = campos[0];
                        string email = campos[1];
                        double salario = double.Parse(campos[2], CultureInfo.InvariantCulture);
                        lista.Add(new Funcionario(nome, email, salario));
                    }
                }

                var emails = lista.Where(f => f.Salario > limite).OrderBy(f => f.Email).Select(f => f.Email);

                var soma = lista.Where(f => f.Nome[0] == 'M').Sum(f => f.Salario);

                Console.WriteLine("Email of people whose salary is more than " + limite.ToString("F2", CultureInfo.InvariantCulture) + ":");
                foreach (string email in emails) {
                    Console.WriteLine(email);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': " + soma.ToString("F2", CultureInfo.InvariantCulture));

            }

            catch (Exception e) {
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(e.Message);
            }

        }

    }
}











