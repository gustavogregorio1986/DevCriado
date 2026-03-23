using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaSimplificada.Entidade
{
    public class Tabuleiro
    {
        public Peca[,] Casas { get; set; } = new Peca[8, 8];

        public void Inicializar()
        {
            // Pretas nas 3 primeiras linhas
            for (int i = 0; i < 3; i++)
                for (int j = (i + 1) % 2; j < 8; j += 2)
                    Casas[i, j] = new Peca { Cor = "Preta" };

            // Brancas nas 3 últimas linhas
            for (int i = 5; i < 8; i++)
                for (int j = (i + 1) % 2; j < 8; j += 2)
                    Casas[i, j] = new Peca { Cor = "Branca" };
        }

        public void Mostrar()
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(Casas[i, j] == null ? ". " : Casas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
