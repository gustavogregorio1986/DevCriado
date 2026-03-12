using ProgramacaoOO.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOO.Control
{
    public class ControlaProduto
    {
        public decimal CaclularTotal(Produto produto)
        {
            decimal resultado = 0;
            resultado = produto.Preco * produto.Quantidade;
            return resultado;
        }
    }
}
