using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class LojasNotifier : IProdutoPreco
    {
        public void Atualizar(decimal produto)
        {
            Console.WriteLine($"O produto ficou mais barato na loja!!!! preço: R${produto}");
        }
    }
}
