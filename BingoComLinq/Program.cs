Random rnd = new Random();

// Gerar cartela com 5 números únicos
var cartela = Enumerable.Range(1, 50)
    .OrderBy(x => rnd.Next())
    .Take(5)
    .ToList();

Console.WriteLine("Sua cartela: " + string.Join(", ", cartela));

// Sortear 10 números
var sorteados = Enumerable.Range(1, 50)
    .OrderBy(x => rnd.Next())
    .Take(10)
    .ToList();

Console.WriteLine("Números sorteados: " + string.Join(", ", sorteados));

// LINQ: verificar acertos
var acertos = cartela.Where(n => sorteados.Contains(n));

Console.WriteLine("Você acertou: " + string.Join(", ", acertos));
Console.WriteLine($"Total de acertos: {acertos.Count()}");