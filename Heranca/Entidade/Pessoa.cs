using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entidade
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public Pessoa(string nome, string Email)
        {
            this.Nome = nome;
            this.Email = Email;
        }

        public override string ToString()
        {
            return Nome + "," + Email;
        }
    }
}
