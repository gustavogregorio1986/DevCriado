Random rnd = new Random();
int numeroSecreto = rnd.Next(1, 11);

List<int> palpites = new List<int> { 2, 5, 7, 10 };

// LINQ: verificar se acertou
bool acertou = palpites.Any(p => p == numeroSecreto);

Console.WriteLine($"Número secreto: {numeroSecreto}");
Console.WriteLine(acertou ? "Você acertou!" : "Você errou!");