using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaSimplificada.Entidade
{
    public class Jogo
    {
        private Tabuleiro tabuleiro = new Tabuleiro();
        private string jogadorAtual = "Branca";

        public void Iniciar()
        {
            tabuleiro.Inicializar();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Turno: {jogadorAtual}");
                tabuleiro.Mostrar();

                Console.WriteLine("Digite origem (linha,coluna): ");
                var origem = Console.ReadLine().Split(',');
                int oi = int.Parse(origem[0]);
                int oj = int.Parse(origem[1]);

                Console.WriteLine("Digite destino (linha,coluna): ");
                var destino = Console.ReadLine().Split(',');
                int di = int.Parse(destino[0]);
                int dj = int.Parse(destino[1]);

                // Movimento simples (sem capturas ainda)
                if (tabuleiro.Casas[oi, oj] != null && tabuleiro.Casas[di, dj] == null)
                {
                    tabuleiro.Casas[di, dj] = tabuleiro.Casas[oi, oj];
                    tabuleiro.Casas[oi, oj] = null;

                    // Promoção a dama
                    if (di == 0 && tabuleiro.Casas[di, dj].Cor == "Branca")
                        tabuleiro.Casas[di, dj].Dama = true;
                    if (di == 7 && tabuleiro.Casas[di, dj].Cor == "Preta")
                        tabuleiro.Casas[di, dj].Dama = true;

                    // Alternar jogador
                    jogadorAtual = jogadorAtual == "Branca" ? "Preta" : "Branca";
                }
            }
        }
    }
}
