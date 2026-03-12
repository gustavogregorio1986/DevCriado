using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuada.Entidade;

namespace Tabuada.Control
{
    public class ControlaValor
    {
        public int Tabuada(Valor valor)
        {
            int resultado = 0;
            for(int i = 0; i <= 10; i++)
            {
                resultado = valor.Numero * i;
                Console.WriteLine($"{valor.Numero} X {i} = {resultado}");
            }

            return resultado;
        }
    }
}
