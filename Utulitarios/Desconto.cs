using System;

namespace Utulitarios
{
    public class Desconto
    {
        public double CalcularDesconto(double ValorVenda)
        {
            double ValorDesconto = 0.0;

            if (ValorVenda == 0 || ValorVenda < 0)
            {
                throw new ArgumentException("O valo da venda não pode ser Zero ou negativo");
            }
            else if (ValorVenda >= 1000 && ValorVenda < 2000)
            {
                // 5% de desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.05);
            }
            else if (ValorVenda >= 2000 && ValorVenda < 5000)
            {
                // 10% de desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.10);
            }
            else if(ValorVenda >= 5000 && < 20000)
            {
                // 50% de desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.5);
            }
            else
            {
                // Sem desconto
                ValorDesconto = ValorVenda * 0.0;
            }

            return ValorDesconto;
        }
    }
}
