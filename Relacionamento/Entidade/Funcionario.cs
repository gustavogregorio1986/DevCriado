using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento.Entidade
{
    public class Funcionario
    {
        public string NomeFuncionario { get; set; }

        public string EmailFuncioanrio { get; set; }

        public string Cpf { get; set; }

        public string Empresa { get; set; }

        public Endereco Endereco { get; set; }

        public List<Telefone> Telefones { get; set; }

        public Funcionario(string nomeFuncionario, string emailFuncioanrio, string cpf, string empresa)
        {
            this.NomeFuncionario = nomeFuncionario;
            this.EmailFuncioanrio = emailFuncioanrio;
            this.Cpf = cpf;
            this.Empresa = empresa;
        }

        public override string ToString()
        {
            return NomeFuncionario + "," + EmailFuncioanrio + "," + Cpf + "," + Empresa;
        }
    }
}
