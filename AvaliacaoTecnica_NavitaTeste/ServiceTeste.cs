using AvaliacaoTecnica_Navita;
using NUnit.Framework;
using System;

namespace AvaliacaoTecnica_NavitaTeste
{
    public class ServiceTeste
    {


        [Test]
        public void EntradaDeDados_true ()
        {
            // arranjo
            string entrada = "121";
            bool saida;

            // inserção
            saida = Tratamento.ValidarEntrada( entrada );

            // assert
            Assert.IsTrue(saida);
        }

        [Test]
        public void EntradaDeDados_false_letra ()
        {
            // arranjo
            string entrada = "12g";
            bool saida;

            // inserção
            saida = Tratamento.ValidarEntrada( entrada );

            // assert
            Assert.IsFalse( saida );
        }

        [Test]
        public void EntradaDeDados_false_negativo ()
        {
            // arranjo
            string entrada = "-123";
            bool saida;

            // inserção
            saida = Tratamento.ValidarEntrada( entrada );

            // assert
            Assert.IsFalse( saida );
        }

        [Test]
        public void VetorizarNumero ()
        {
            // arranjo
            string entrada = "123";
            int[] saida;
            int[] saidaEsperada = new int[]{ 1, 2, 3 };

            // inserção
            saida = Tratamento.VetorizarNumero( entrada );

            // assert
            Assert.AreEqual( int.Parse( string.Join( "", saidaEsperada)),
                             int.Parse( string.Join( "", saida)), 0, "Valor incorreto" );
        }

        [Test]
        public void OrdenarVetor ()
        {
            // arranjo
            int[] entrada = new int[] { 3, 2, 1 };
            int[] saida;
            int[] saidaEsperada = new int[] { 1, 2, 3 };

            // inserção
            saida = Ordenacao.quickSort( entrada );

            // assert
            Assert.AreEqual( int.Parse( string.Join( "", saidaEsperada ) ),
                             int.Parse( string.Join( "", saida ) ), 0, "Valor incorreto" );
        }
    }
}