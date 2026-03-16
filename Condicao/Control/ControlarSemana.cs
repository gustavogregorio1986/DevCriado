using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao.Control
{
    public class ControlarSemana
    {
        public void VerificarDia(string dia)
        {
            switch (dia.ToLower())
            {
                case "segunda-feira":
                    Console.WriteLine("Hoje é Segunda-feira.");
                    break;
                case "terça-feira":
                    Console.WriteLine("Hoje é Terça-feira.");
                    break;
                case "quarta-feira":
                    Console.WriteLine("Hoje é Quarta-feira.");
                    break;
                case "quinta-feira":
                    Console.WriteLine("Hoje é Quinta-feira.");
                    break;
                case "sexta-feira":
                    Console.WriteLine("Hoje é Sexta-feira.");
                    break;
                case "sábado":
                    Console.WriteLine("Hoje é Sábado.");
                    break;
                case "domingo":
                    Console.WriteLine("Hoje é Domingo.");
                    break;
                default:
                    Console.WriteLine("Dia inválido. Por favor, insira um dia da semana válido.");
                    break;
            }
        }
    }
}
