using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidade
{
    public class PessoaCLT : Pessoa
    {
        public string Clt { get; set; }

        public PessoaCLT(string nome, string Email, string clt) : base(nome, Email)
        {
            this.Clt = clt;
        }

        public override string ToString()
        {
            return base.ToString() + "," + Clt;
        }
    }
}
