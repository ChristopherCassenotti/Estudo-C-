using System;

namespace Aula26
{
    public class Jogador
    {
        public int energia=100;
        public bool vivo=true;

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();

            j1.energia = 50;

            Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
        }
    }
}
