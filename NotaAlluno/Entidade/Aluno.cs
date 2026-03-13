using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAlluno.Entidade
{
    public class Aluno
    {
        public string NomeAluno { get; set; }

        public string EmailAluno { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Recuperacao { get; set; }

        public Aluno()
        {
            
        }

        public Aluno(string nomeAluno, string emailAluno, double nota1, double nota2)
        {
            this.NomeAluno = nomeAluno;
            this.EmailAluno = emailAluno;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
        }

        public override string ToString()
        {
            return NomeAluno + "," + EmailAluno + "," + Nota1 + "," + Nota2;
        }
    }
}
