using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz.Control
{
    public class LoopMatriz
    {
        public void ImpressaoMatirz()
        {
            for(int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write($"{ i *j,6}");
                }

            }
        }
    }
}
