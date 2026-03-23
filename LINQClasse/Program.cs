using LINQClasse.Entidade;

List<Produto> produtos = new List<Produto>
{
    new Produto { NomeProduto = "Notebook", Descricao = "Dell XPS", Preco = 8000, Quantidade = 5, Pessoa = new Pessoa { NomePessoa = "Ana", EmailPessoa = "ana@email.com", Cpf = "111" } },
    new Produto { NomeProduto = "Celular", Descricao = "iPhone", Preco = 6000, Quantidade = 10, Pessoa = new Pessoa { NomePessoa = "Carlos", EmailPessoa = "carlos@email.com", Cpf = "222" } },
    new Produto { NomeProduto = "Mouse", Descricao = "Logitech", Preco = 200, Quantidade = 50, Pessoa = new Pessoa { NomePessoa = "Bruna", EmailPessoa = "bruna@email.com", Cpf = "333" } }
};

var caros = produtos.Where(p => p.Preco > 1000);

foreach(var car in caros)
{
    Console.WriteLine(car);
}

var ordenados = produtos.OrderBy(p => p.Preco);

foreach(var ordem in ordenados)
{
    Console.WriteLine(ordem);
}

var nomes = produtos.Select(p => p.NomeProduto);

foreach(var nome in nomes)
{
    Console.WriteLine(nome);
}

var agrupados = produtos.GroupBy(p => p.Pessoa.NomePessoa);

foreach (var grupo in agrupados)
{
    Console.WriteLine($"Pessoa: {grupo.Key}");
    foreach (var prod in grupo)
    {
        Console.WriteLine($" - {prod.NomeProduto} | Preço: {prod.Preco} | Quantidade: {prod.Quantidade}");
    }
}

var total = produtos.Sum(p => p.Preco * p.Quantidade);

Console.WriteLine(total);

var maisCaro = produtos.MaxBy(p => p.Preco);


Console.WriteLine(maisCaro);

bool existeBarato = produtos.Any(p => p.Preco < 500);

Console.WriteLine(existeBarato);

var produtoAna = produtos.FirstOrDefault(p => p.Pessoa.NomePessoa == "Ana");

Console.WriteLine(produtoAna);

var contagemPorPessoa = produtos
    .GroupBy(p => p.Pessoa.NomePessoa)
    .Select(g => new { Pessoa = g.Key, QuantidadeProdutos = g.Count() });

foreach(var conta in contagemPorPessoa)
{
    Console.WriteLine(conta);
}

var relatorio = produtos.Select(p => new
{
    Produto = p.NomeProduto,
    Preco = p.Preco,
    Quantidade = p.Quantidade,
    Pessoa = p.Pessoa.NomePessoa,
    Email = p.Pessoa.EmailPessoa,
    CPF = p.Pessoa.Cpf
});

foreach (var item in relatorio)
{
    Console.WriteLine($"{item.Produto} | Preço: {item.Preco} | Quantidade: {item.Quantidade} | Dono: {item.Pessoa} ({item.Email}, CPF: {item.CPF})");
}