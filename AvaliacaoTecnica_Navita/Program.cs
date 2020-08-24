using System;

namespace AvaliacaoTecnica_Navita
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine( "Digite um número inteiro maior que zero!\n" );
            Console.Write( "Número = " );

            string entrada = Console.ReadLine();
            Console.WriteLine( $"R: {Service.EncontrarMaiorNumero( entrada )}" );
           

            Console.ReadKey();
        }


    }
}
