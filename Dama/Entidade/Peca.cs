using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama.Entidade
{
    public class Peca
    {
        public string Cor { get; set; } // "Branca" ou "Preta"
        public bool Dama { get; set; } // vira dama ao chegar na última linha
    }
}
