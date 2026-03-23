
using BatalhaRPG.Entidade;

var personagens = new List<Personagem>
        {
            new Personagem { Nome = "Ana", Vida = 100, Ataque = 20, Equipe = "Azul" },
            new Personagem { Nome = "Carlos", Vida = 80, Ataque = 25, Equipe = "Vermelha" },
            new Personagem { Nome = "Bruna", Vida = 120, Ataque = 15, Equipe = "Azul" }
        };

        // Quem ainda está vivo
        var vivos = personagens.Where(p => p.Vida > 0);
        Console.WriteLine("Personagens vivos:");
        foreach (var v in vivos) Console.WriteLine(v);

        // Ranking por ataque
        var rankingAtaque = personagens.OrderByDescending(p => p.Ataque);
        Console.WriteLine("\nRanking por ataque:");
        foreach (var r in rankingAtaque) Console.WriteLine(r);

        // Média de ataque
        var mediaAtaque = personagens.Average(p => p.Ataque);
        Console.WriteLine($"\nMédia de ataque: {mediaAtaque}");

        // Agrupados por equipe
        var equipes = personagens.GroupBy(p => p.Equipe);
        Console.WriteLine("\nEquipes:");
        foreach (var grupo in equipes)
        {
            Console.WriteLine($"Equipe: {grupo.Key}");
            foreach (var p in grupo)
            {
                Console.WriteLine($" - {p.Nome} (Vida: {p.Vida}, Ataque: {p.Ataque})");
            }
        }

        // Estatísticas extras
        var maisForte = personagens.MaxBy(p => p.Ataque);
        Console.WriteLine($"\nMais forte: {maisForte.Nome} com {maisForte.Ataque} de ataque");

        var maisResistente = personagens.MaxBy(p => p.Vida);
        Console.WriteLine($"Mais resistente: {maisResistente.Nome} com {maisResistente.Vida} de vida");