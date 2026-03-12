using Tabuada.Control;
using Tabuada.Entidade;

Valor valor = new Valor();
valor.Numero = 8;

Console.WriteLine("Numero: " + valor.Numero);

ControlaValor controlaValor = new ControlaValor();
controlaValor.Tabuada(valor);