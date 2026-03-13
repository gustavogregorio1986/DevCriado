using Relacionamento.Entidade;

Funcionario funcionario = new Funcionario("Rafael","rafael@gmail.com.com","1234567890","Target Software");

Console.WriteLine("Funcionario: " + funcionario);

funcionario.Endereco = new Endereco();
funcionario.Endereco.Logradouro = "Rua nayrton Sena numro 56";
funcionario.Endereco.Bairro = "Laranjeiras";
funcionario.Endereco.Cidade = "Rio de Janweiro";
funcionario.Endereco.Uf = "Rio de Janweiro";

Console.WriteLine("Lohgradouro: " + funcionario.Endereco.Logradouro);
Console.WriteLine("Lohgradouro: " + funcionario.Endereco.Bairro);
Console.WriteLine("Lohgradouro: " + funcionario.Endereco.Cidade);
Console.WriteLine("Lohgradouro: " + funcionario.Endereco.Uf);

List<Telefone> listaTel = new List<Telefone>();
listaTel.Add(new Telefone("telefone comercial","234556654"));
listaTel.Add(new Telefone("telefone celular", "9867688787"));

foreach (Telefone t in listaTel)
{
    Console.WriteLine(t);
}