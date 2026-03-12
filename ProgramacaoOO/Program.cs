using ProgramacaoOO.Control;
using ProgramacaoOO.Entidade;

Produto produto = new Produto();

produto.NomeProduto = "Computador";
produto.Descricao = "Computador DELL com potencia maxiam paar atividades pesadas";
produto.Preco = 7898;
produto.Quantidade = 4;

Console.WriteLine("Nome do Produto: " + produto.NomeProduto);
Console.WriteLine("Descrição do Produto: " + produto.Descricao);
Console.WriteLine("Preço do Produto: " + produto.Preco);
Console.WriteLine("Quantidade do Produto: " + produto.Quantidade);

ControlaProduto controlaProduto = new ControlaProduto();
Console.WriteLine("Calculo do produto: R$ " + controlaProduto.CaclularTotal(produto));
