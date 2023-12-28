using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.Exceptions;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        public static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicao);

            Console.WriteLine(posicao.ToPosicao());

            Console.ReadLine();
        }
    }
}