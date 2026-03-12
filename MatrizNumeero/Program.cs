using MatrizNumeero.Control;
using MatrizNumeero.Entidade;

Valor valor = new Valor();
valor.Numero = 21;

Console.WriteLine($"Numero: {valor.Numero}");

ControlaValor controlaValor = new ControlaValor();
controlaValor.ImpressaoMatriz(valor);
controlaValor.ImpressaoMatrizSemMultiplicacao(valor);