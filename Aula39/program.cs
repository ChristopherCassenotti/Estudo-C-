using System;

namespace Aula39
{
    class Carro
    {
        private int velMax;

        public int vm
        {
            get
            {
                return velMax;
            }
            set
            {
                if (value < 0)
                {
                    velMax = 0;
                }
                else if (value > 300)
                {
                    velMax = 300;
                }
                else
                {
                    velMax = value;
                }
            }
        }
        public Carro()
        {
            vm = 120;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            carro1.vm = -10;

            Console.WriteLine("Velocidade: {0}", carro1.vm);
        }
    }
}
