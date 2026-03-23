using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama.Entidade
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
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Casas[i, j] == null) Console.Write(". ");
                    else Console.Write(Casas[i, j].Cor[0] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
