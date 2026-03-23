using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQClasse.Entidade
{
    public class Produto
    {
        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Pessoa Pessoa { get; set; }

        public override string ToString()
        {
            return $"{NomeProduto} | {Descricao} | Preço: {Preco} | Quantidade: {Quantidade} | Dono: {Pessoa?.NomePessoa} ({Pessoa?.EmailPessoa}, CPF: {Pessoa?.Cpf})";
        }
    }

}
