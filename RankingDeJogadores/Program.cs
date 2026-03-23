var jogadores = new List<(string Nome, int Pontos)>
{
    ("Ana", 50),
    ("Carlos", 70),
    ("Bruna", 40)
};

// LINQ: ordenar por pontuação
var ranking = jogadores.OrderByDescending(j => j.Pontos);

Console.WriteLine("Ranking:");
foreach (var j in ranking)
{
    Console.WriteLine($"{j.Nome} - {j.Pontos} pontos");
}
