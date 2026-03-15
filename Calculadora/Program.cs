using Calculadora.Entidade;
using Calculadora.Control;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criar objeto com os valores
        Valor valor = new Valor
        {
            Numero1 = 10,
            Numero2 = 2
        };

        // Instanciar a calculadora
        ControlaCalculadora calc = new ControlaCalculadora();

        Console.WriteLine("Soma: " + calc.Somar(valor));
        Console.WriteLine("Subtração: " + calc.Subtracao(valor));
        Console.WriteLine("Multiplicação: " + calc.Multiplicacao(valor));
        Console.WriteLine("Divisão: " + calc.Divisao(valor)); // retorna NaN se divisor for 0
    }
}