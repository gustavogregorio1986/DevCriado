using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaRPG.Entidade
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public string Equipe { get; set; }

        public override string ToString()
        {
            return $"{Nome} | Vida: {Vida} | Ataque: {Ataque} | Equipe: {Equipe}";

        }
    }

}
