using NotaAlluno.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAlluno.Control
{
    public class ControlarAluno
    {
        public double MediaAluno(Aluno aluno)
        {
            return (aluno.Nota1 + aluno.Nota2) / 2;
        }

        public string SituacaoAluno(Aluno aluno)
        {
            double media = MediaAluno(aluno);

            if (media >= 6.0)
            {
                return "Aprovado";
            }
            else if (media >= 5.0)
            {
                double mediaRecuperacao = (media + aluno.Recuperacao) / 2;
                if (mediaRecuperacao >= 6.0)
                    return "Aprovado em Recuperação";
                else
                    return "Reprovado após Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
