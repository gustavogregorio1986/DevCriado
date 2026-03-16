using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar.Entidade
{
    public class Empresa
    {
        public string NomeEmpresa { get; set; }

        public string Cnpj { get; set; }

        public string EmailEmpresa { get; set; }


        public int TotalPessoas { get; set; }



        public Empresa()
        {
            
        }

        public Empresa(string nome, string cnpj, string email, int totalPessoas)
        {
            NomeEmpresa = nome;
            Cnpj = cnpj;
            EmailEmpresa = email;
            TotalPessoas = totalPessoas;
        }

        // Sobrescrevendo ToString para imprimir bonito no Console.WriteLine
        public override string ToString()
        {
            return $"{NomeEmpresa} - {Cnpj} - {EmailEmpresa} - Funcionários: {TotalPessoas}";
        }
    }
}
