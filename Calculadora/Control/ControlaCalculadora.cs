using Calculadora.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Control
{
    public class ControlaCalculadora
    {
        public double Somar(Valor valor)
        {
            double result = 0;
            result = valor.Numero1 + valor.Numero2;
            return result;
        }

        public double Subtracao(Valor valor)
        {
            double result = 0;
            result = valor.Numero1 - valor.Numero2;
            return result;
        }

        public double Multiplicacao(Valor valor)
        {
            double result = 0;
            result = valor.Numero1 * valor.Numero2;
            return result;
        }

        public double Divisao(Valor valor)
        {
            if (valor.Numero2 == 0)
                return double.NaN; // ou 0, ou qualquer valor que faça sentido no seu contexto

            return valor.Numero1 / valor.Numero2;
        }
    }
}
