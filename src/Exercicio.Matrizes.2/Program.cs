namespace System.Collections.Generic;
class Program {
    static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        for (int i = 0; i < n; i++) {
            string[] s = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++) {
                mat[i, j] = int.Parse(s[j]);
            }
        }

        Console.WriteLine("Diagonal principal: ");
        for (int i = 0; i < n; i++) {
            Console.Write(mat[i, i] + " ");
        }

        Console.WriteLine();
        int contar = 0;
        for (int i = 0; i < n; i++) {

            for (int j = 0; j < n; j++) {

                if (mat[i, j] < 0) {
                    contar++;
                }
            }
        }
        Console.WriteLine("Numeros negativos = " + contar);

    }
}



