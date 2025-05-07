using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Menos : Calcular
    {
        public decimal Resultado(decimal Valor1, decimal valor2)
        {
            return Valor1 - valor2;
        }
    }
}
