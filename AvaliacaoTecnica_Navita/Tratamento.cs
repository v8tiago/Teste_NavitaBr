using System;
using System.Linq;
using System.Threading;

namespace AvaliacaoTecnica_Navita
{
    public static class Tratamento
    {
        /// <summary>
        /// Executa rotina para validar a entrada como um inteiro positivo.
        /// </summary>
        /// <param name="entrada">String a ser validada como número</param>
        /// <returns></returns>
        public static bool ValidarEntrada (string entrada)
        {
            int numero;
            bool resultado;

            resultado = int.TryParse( entrada, out numero );

            if (numero < 0)
            {
                return false;
            }

            return resultado;
        }

        /// <summary>
        /// Rotina de loop até o usuário acertar o valor de entrada.
        /// </summary>
        /// <param name="entrada">Valor a ser ordenado</param>
        /// <returns></returns>
        public static int EntradaValor (string entrada)
        {
            string MensagemDefault = "Voce não digitou um número inteiro positivo. Vamos tentar novamente em... ";

            while (!ValidarEntrada( entrada ))
            {
                Console.Write( MensagemDefault );

                for (int i = 5; i > 0; i--)
                {
                    Console.SetCursorPosition( MensagemDefault.Length + 1, Console.CursorTop );
                    Console.Write( $"{i}s" );
                    Thread.Sleep( 1000 );
                }

                Console.Clear();
                Console.WriteLine( "Digite um número inteiro maior que zero!\n" );
                Console.Write( "Número = " );
                entrada = Console.ReadLine();
             
            }

            Console.WriteLine();
            return int.Parse(entrada);
        }

        /// <summary>
        /// Rotina para vetorizar uma string contendo apenas números.
        /// </summary>
        /// <param name="numero">Número inteiro</param>
        /// <returns></returns>
        public static int[] VetorizarNumero (string numero)
        {
            string num = numero.ToString();

            int[] NumeroParaOrdenar = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                NumeroParaOrdenar[i] = int.Parse( num.Substring( i, 1 ) );
            }
            return NumeroParaOrdenar;
        }

        /// <summary>
        /// Rotina para saída do resultado com base no vetor ordenado. 
        /// </summary>
        /// <param name="NumeroOrdenado">Vetor com numero ordenado de forma crescente</param>
        /// <returns></returns>
        public static int SaidaValor(int[] NumeroOrdenado)
        {
            int resultado = int.Parse( string.Join( "", NumeroOrdenado.Reverse() ) );

            if (resultado > 100000000)
                resultado =  -1;

            return resultado;
        }
    }
}
