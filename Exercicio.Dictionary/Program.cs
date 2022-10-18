namespace Exercicios {
    class Program {
        static void Main(string[] args) {


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream) {
                        string[] registroDeVotacao = sr.ReadLine().Split(',');
                        string canditado = registroDeVotacao[0];
                        int votos = int.Parse(registroDeVotacao[1]);

                        if (dictionary.ContainsKey(canditado)) {
                            dictionary[canditado] += votos;
                        }
                        else {
                            dictionary[canditado] = votos;
                        }
                    }

                    foreach (var item in dictionary) {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }


            }
            catch (Exception e) {
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
