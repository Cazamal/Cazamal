using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrex pos = new PosicaoXadrex('a', 1);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());

                Console.ReadLine();

            }catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
