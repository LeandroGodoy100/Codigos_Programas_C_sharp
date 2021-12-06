using System;
using System.Collections.Generic;
using System.Text;

namespace Leandro
{
    class Produto
    {
       public string Nome;
       public double Preco;
       public int Quantidade;

        public double ValorTotalDeEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
