using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ClientesNotifier : IProdutoPreco
    {
        public void Atualizar(decimal produto)
        {
            Console.WriteLine($"O Produto ficou mais barato meu cliente!!! Preço: R${produto}");
        }
    }
}
