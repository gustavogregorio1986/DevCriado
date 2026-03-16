using Listar.Entidade;

List<Empresa> listaEmpresa  = new List<Empresa>();
listaEmpresa.Add(new Empresa("Target Software","123456789087","contato@tareget.com.br",20000));
listaEmpresa.Add(new Empresa("Solutis", "1123455656656", "contato@solutis.com.br", 20000));
listaEmpresa.Add(new Empresa("Qintess", "34566778877666", "contato@qintess.com.br", 890000));
listaEmpresa.Add(new Empresa("Capgemini", "34567877655445", "contato@capgemini.com.br", 20000));

foreach (var empresa in listaEmpresa)
{
    Console.WriteLine(empresa);
}

int totalFuncionarios = listaEmpresa.Sum(f => f.TotalPessoas);

Console.WriteLine(totalFuncionarios);

int maxFuncionarios = listaEmpresa.Max(e => e.TotalPessoas);
int minFuncionarios = listaEmpresa.Min(e => e.TotalPessoas);



Console.WriteLine(minFuncionarios);
Console.WriteLine(maxFuncionarios);

var grandes = listaEmpresa.Where(e => e.TotalPessoas > 100000);

Console.WriteLine(grandes);

var ordenadas = listaEmpresa.OrderByDescending(e => e.TotalPessoas);

Console.WriteLine(ordenadas);

var solutis = listaEmpresa.FirstOrDefault(e => e.NomeEmpresa == "Solutis");

Console.WriteLine(solutis);



foreach (var empresa1 in grandes)
{
    Console.WriteLine("Grande empresa: " + empresa1.NomeEmpresa);
}

var grupos = listaEmpresa.GroupBy(e =>
    e.TotalPessoas > 500000 ? "Grande" :
    e.TotalPessoas > 50000 ? "Média" : "Pequena");

foreach (var grupo in grupos)
{
    Console.WriteLine($"{grupo.Key}: {grupo.Count()} empresas");
}

var contatos = listaEmpresa.Select(e => new { e.NomeEmpresa, e.EmailEmpresa });
foreach (var c in contatos)
{
    Console.WriteLine($"{c.NomeEmpresa} - {c.EmailEmpresa}");
}

var top2 = listaEmpresa.OrderByDescending(e => e.TotalPessoas).Take(2);
foreach (var empresa in top2)
{
    Console.WriteLine("Top empresa: " + empresa.NomeEmpresa);
}

var pagina1 = listaEmpresa.Skip(0).Take(2); // primeiras 2
var pagina2 = listaEmpresa.Skip(2).Take(2); // próximas 2

Console.WriteLine(pagina1);
Console.WriteLine(pagina2);

var grupos1 = listaEmpresa.GroupBy(e => e.NomeEmpresa[0]);
foreach (var grupo in grupos1)
{
    Console.WriteLine($"Empresas que começam com {grupo.Key}:");
    foreach (var empresa in grupo)
        Console.WriteLine(" - " + empresa.NomeEmpresa);
}

