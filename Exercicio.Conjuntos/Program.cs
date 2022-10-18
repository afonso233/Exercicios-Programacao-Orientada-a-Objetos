namespace Exercicios {
    class Program {
        static void Main(string[] args) {

            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int codigo = int.Parse(Console.ReadLine());
                cursoA.Add(codigo);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int codigo = int.Parse(Console.ReadLine());
                cursoB.Add(codigo);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int codigo = int.Parse(Console.ReadLine());
                cursoC.Add(codigo);
            }

            HashSet<int> tudo = new HashSet<int>(cursoA);
            tudo.UnionWith(cursoB);
            tudo.UnionWith(cursoC);
            Console.Write("Total students: " + tudo.Count);


        }
    }
}