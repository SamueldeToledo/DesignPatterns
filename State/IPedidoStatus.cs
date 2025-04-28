using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IPedidoStatus
    {
        public void Criado(Pedido pedido);
        public void Finalizado(Pedido pedido);
        public void Expedido(Pedido pedido);
        public void Recebido(Pedido pedido);
    }
}
