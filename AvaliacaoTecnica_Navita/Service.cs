namespace AvaliacaoTecnica_Navita
{
    static class Service
    {
        private static int[] NumeroVetorizado;
        private static int[] NumeroOrdenado;
        private static int Numero;

        /// <summary>
        /// Serviço para encontrar o maior número a partir da entrada.
        /// </summary>
        /// <param name="entrada">Digite um número inteiro maior que zero</param>
        /// <returns></returns>
        public static int EncontrarMaiorNumero(string entrada)
        {
            Numero = Tratamento.EntradaValor( entrada );

            NumeroVetorizado = Tratamento.VetorizarNumero( Numero.ToString() );

            NumeroOrdenado = Ordenacao.quickSort( NumeroVetorizado );

            return Tratamento.SaidaValor( NumeroOrdenado );

        }

    }
}
