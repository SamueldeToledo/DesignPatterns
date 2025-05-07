using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Operacoes
    {
        private Calcular _operacao;

        public decimal calculo(Calcular operacao, decimal valor1, decimal valor2)
        {
            if (operacao is null)
            {
                Console.WriteLine("Instancie uma operação");
                throw new Exception() ;
            }
            _operacao = operacao;
           return _operacao.Resultado(valor1, valor2);
        }
    }
}
