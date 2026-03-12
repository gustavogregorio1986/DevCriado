using ParImpar.Control;
using ParImpar.Entidade;

Valor valor = new Valor();
valor.Numero = 43;

Console.WriteLine("O numero: " + valor.Numero);

ControlarValor controlarValor = new ControlarValor();
controlarValor.NumerParImpar(valor);