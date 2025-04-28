using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PedidoFinalizado : IPedidoStatus
    {
        public void Criado(Pedido pedido)
        {
            Console.WriteLine("O Pedido já foi recebido.");
        }

        public void Expedido(Pedido pedido)
        {
            Console.WriteLine("O Pedido está sendo expedido");
            pedido.SetState(new PedidoExpedido());
        }

        public void Finalizado(Pedido pedido)
        {
            Console.WriteLine("O Pedido já foi finalizado.");
        }

        public void Recebido(Pedido pedido)
        {
            Console.WriteLine("O Pedido já foi recebido.");
        }
    }
}
