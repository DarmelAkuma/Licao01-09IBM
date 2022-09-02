using System;

namespace JogoCopo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite quantos movimentos serão realizados:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite em qual copo se inicia o jogo: (A, B ou C)");
            char copo = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite qual movimento sera realizado:(1, 2 ou 3)");
                int movimento = int.Parse(Console.ReadLine());

                if (movimento == 1 && (copo == 'A' || copo == 'B'))
                    copo = (copo == 'A' ? 'B' : 'A');
                else if (movimento == 2 && (copo == 'B' || copo == 'C'))
                    copo = (copo == 'B' ? 'C' : 'B');
                else if (movimento == 3 && (copo == 'A' || copo == 'C'))
                    copo = (copo == 'C' ? 'A' : 'C');
                Console.WriteLine("A moeda esta no copo: " + copo);
            }
        }
    }
}
