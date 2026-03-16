using SwitchCase.Control;
using SwitchCase.Entidade;

Valor valor = new Valor();
valor.Numero = 11;

Console.WriteLine("Numero: " + valor.Numero);

ControlaValor controlaValor = new ControlaValor();
controlaValor.SituacaoValor(valor);