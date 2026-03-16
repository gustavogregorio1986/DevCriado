using Condicao.Control;
using Condicao.Entidade;

semana semana = new semana();
semana.Dia = "Segunda-feira";
Console.WriteLine(semana.Dia);

ControlarSemana controlarSemana = new ControlarSemana();
controlarSemana.VerificarDia(semana.Dia);