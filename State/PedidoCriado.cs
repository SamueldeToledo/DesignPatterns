using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PedidoCriado : IPedidoStatus
    {
        public void Criado(Pedido pedido)
        {
            Console.WriteLine("Pedido criado");
        }

        public void Expedido(Pedido pedido)
        {
            Console.WriteLine("O pedido ainda não foi finalizado.");
        }

        public void Finalizado(Pedido pedido)
        {
            Console.WriteLine("Pedido Finalizado");
            pedido.SetState(new PedidoExpedido());
        }

        public void Recebido(Pedido pedido)
        {
            Console.WriteLine("O pedido ainda não foi finalizado.");
        }
    }
}
