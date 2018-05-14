using System;
using Utulitarios;
using NUnit.Framework;

namespace UnitDesconto
{
    [TestFixture]
    public class DescontoTest
    {
        // Casao de Teste#1: Valor das Vendas é Maior ou Igual a 1000 : Verificação
        [Test]
        public void MaiorOuIgual_1000()
        {
            Desconto oDesconto = new Desconto();
            Assert.AreEqual(950, oDesconto.CalcularDesconto(1000));
        }

        // Caso de Teste#2: Valor das Vendas e Maior ou Igual a 2000 : Verificação
        [Test]
        public void MaiorOuIgual_2000()
        {
            Desconto obj = new Desconto();
            Assert.AreEqual(1800, obj.CalcularDesconto(2000));
        }

        // Caso de Teste#3: Valor das Vendas é Maior ou igual a 5000 : Verificação
        [Test]
        public void MaiorOuIgual_5000()
        {
            Desconto obj = new Desconto();
            Assert.AreEqual(2500, obj.CalcularDesconto(5000));
        }

        // Caso de Teste#4: Valor das Vendas é 0 : Verificação
        [Test]
        public void ValorZero()
        {
            Desconto obj = new Desconto();
            try
            {
                obj.CalcularDesconto(0);
            }
            catch (Exception ex) { throw ex; }
        }

        // Caso de Teste#5: Valor das Vendas é menor que 1000 : Verificação
        [Test]
        public void AbaixoDe_1000()
        {
            Desconto obj = new Desconto();
            Assert.AreEqual(999, obj.CalcularDesconto(999));
        }

        // Caso de Teste#6: Valor das Vendas não produziu os resultados esperados : Verificação
        [Test]
        public void Mil()
        {
            Desconto obj = new Desconto();
            Assert.AreNotEqual(930, obj.CalcularDesconto(1000));
        }

        // Caso de Teste#7: Valor das Vendas não produziu os resultados esperados : Verificação
        [Test]
        public void DoisMil()
        {
            Desconto obj = new Desconto();
            Assert.AreNotEqual(1900, obj.CalcularDesconto(2000));
        }
    }
}
