using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidade
{
    public class PessoaPJ : Pessoa
    {
        public PessoaPJ(string nome, string Email, string cnpj) : base(nome, Email)
        {
            this.CNPJ = cnpj;
        }

        public string CNPJ { get; set; }

        public override string ToString()
        {
            return base.ToString() + "," + CNPJ;
        }
    }
}
