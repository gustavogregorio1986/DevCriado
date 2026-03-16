using SwitchCase.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase.Control
{
    public class ControlaValor
    {
        public void SituacaoValor(Valor valor)
        {
            switch (valor.Numero) {
                case 1:
                    Console.WriteLine("Numero 1");
                    break;
                case 2:
                    Console.WriteLine("Numero 2");
                    break;
                case 3:
                    Console.WriteLine("Numero 3");
                    break;
                case 4:
                    Console.WriteLine("Numero 4");
                    break;
                case 5:
                    Console.WriteLine("Numero 5");
                    break;
                case 6:
                    Console.WriteLine("Numero 6");
                    break;
                case 7:
                    Console.WriteLine("Numero 8");
                    break;
                case 8:
                    Console.WriteLine("Numero 8");
                    break;
                case 9:
                    Console.WriteLine("Numero 9");
                    break;
                case 10:
                    Console.WriteLine("Numero 10");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }

        }
    }
}
