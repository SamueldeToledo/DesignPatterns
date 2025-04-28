using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PedidoExpedido: IPedidoStatus
    {
        public void Criado(Pedido pedido)
        {
            Console.WriteLine("Não é possível criar o pedido novamente");
        }

        public void Expedido(Pedido pedido)
        {
            Console.WriteLine("O Pedido ja foi expedido.");
        }

        public void Finalizado(Pedido pedido)
        {
            Console.WriteLine("Não é possível finalizar o pedido novamente");
        }

        public void Recebido(Pedido pedido)
        {
            Console.WriteLine("O Pedido está á caminho do cliente");
            pedido.SetState(new PedidoRecebido());
        }
    }
}
