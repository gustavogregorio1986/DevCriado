using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetorPaiImpar.Entidade;

namespace VetorPaiImpar.Control
{
    public class ControlaValor
    {
        public void VetorParImpar(Valor valor)
        {
            for(int i = 0; i <= valor.Numero; i++)
            {
                if (valor.Numero % 2 == 0)
                {
                    Console.WriteLine("Numero par" + valor.Numero);
                }
                else
                {
                    Console.WriteLine("Numero impar" + valor.Numero);
                }
        }
    }
}
