using ParImpar.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar.Control
{
    public class ControlarValor
    {
        public void NumerParImpar(Valor valor)
        {
            if(valor.Numero % 2 == 0)
            {
                Console.WriteLine($"O {valor.Numero} é par");
            }
            else
            {
                Console.WriteLine($"O {valor.Numero} é impar");
            }
        }
    }
}
