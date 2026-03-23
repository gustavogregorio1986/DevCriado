List<string> cartas = new List<string> { "Ás", "Rei", "Rainha", "Valete", "10", "9" };
Random rnd = new Random();

// Embaralhar com LINQ
var embaralhadas = cartas.OrderBy(c => rnd.Next()).ToList();

// Pegar 2 cartas
var mao = embaralhadas.Take(2);

Console.WriteLine("Sua mão: " + string.Join(", ", mao));