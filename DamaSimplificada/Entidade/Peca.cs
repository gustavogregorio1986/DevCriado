using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaSimplificada.Entidade
{
    public class Peca
    {
        public string Cor { get; set; } // "Branca" ou "Preta"
        public bool Dama { get; set; } = false;

        public override string ToString()
        {
            return Dama ? (Cor == "Branca" ? "♔" : "♚") : (Cor == "Branca" ? "○" : "●");
        }
    }
}
