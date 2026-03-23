using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQClasse.Entidade
{
    public class Pessoa
    {
        public string NomePessoa { get; set; }

        public string EmailPessoa { get; set; }

        public string Cpf { get; set; }

        public Produto Produto { get; set; }

        public override string ToString()
        {
            return $"{NomePessoa} | {EmailPessoa} | CPF: {Cpf}";
        }


    }
}
