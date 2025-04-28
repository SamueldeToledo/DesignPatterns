using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Pedido
    {
        private IPedidoStatus _status;

        public Pedido()
        {
            _status = new PedidoCriado();
        }

        public void SetState(IPedidoStatus novoStatus)
        {
            _status = novoStatus;
        }

        public void Finalizado() 
        {
            _status.Finalizado(this);
        }
        public void Expedido()
        {
            _status.Recebido(this);

        }
        public void Recebido()
        {
            _status.Recebido(this);

        }
    }
}
