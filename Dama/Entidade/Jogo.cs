using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama.Entidade
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

                // Aqui você implementaria entrada do usuário (origem/destino)
                // e regras de movimento/captura

                // Alternar jogador
                jogadorAtual = jogadorAtual == "Branca" ? "Preta" : "Branca";
            }
        }
    }
}
