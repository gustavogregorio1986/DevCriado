using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento.Entidade
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}
