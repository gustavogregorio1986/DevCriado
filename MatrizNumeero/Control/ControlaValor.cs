using MatrizNumeero.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizNumeero.Control
{
    public class ControlaValor
    {
        public void ImpressaoMatriz(Valor valor)
        {
            for (int i = 0; i <= valor.Numero; i++)
            {
                for (int j = 0; j <= valor.Numero; j++)
                {
                    Console.Write($"{i * j,6}");
                }

            }
        }

        public void ImpressaoMatrizSemMultiplicacao(Valor valor)
        {
            for (int i = 0; i <= valor.Numero; i++)
            {
                for (int j = 0; j <= valor.Numero; j++)
                {
                    Console.Write($"{i},{j,6}");
                }

            }
        }
    }
}
