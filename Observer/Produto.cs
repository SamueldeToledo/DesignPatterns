using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Produto
    {
        private List<IProdutoPreco> Precos = new List<IProdutoPreco>();
        public decimal Preco { get; set; }

        public void PrecoAlterado(IProdutoPreco notificar)
        {
            Precos.Add(notificar);
        }

        public void NotificarPrecos(decimal preco)
        {
            foreach (var precoProduto in Precos)
            {
                precoProduto.Atualizar(preco);
            }
        }


    }
}
