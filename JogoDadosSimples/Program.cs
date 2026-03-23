Random rnd = new Random();
List<int> dados = new List<int>();

// Jogar 5 dados
for (int i = 0; i < 5; i++)
{
    dados.Add(rnd.Next(1, 7));
}

// Mostrar os resultados
Console.WriteLine("Jogada: " + string.Join(", ", dados));

// LINQ: contar quantos números iguais saíram
var agrupados = dados.GroupBy(d => d)
    .Select(g => new { Numero = g.Key, Quantidade = g.Count() });

foreach (var grupo in agrupados)
{
    Console.WriteLine($"Número {grupo.Numero} saiu {grupo.Quantidade} vezes");
}