using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Mais : Calcular
    {
        public decimal Resultado(decimal Valor, decimal valor2)
        {
            return Valor + valor2;
        }
    }
}
