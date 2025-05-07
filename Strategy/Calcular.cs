using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Calcular
    {
        public decimal Resultado(decimal Valor1, decimal valor2);
    }
}
