using System;

namespace Aula35
{

    class Base
    {//base
        public Base()
        {
            Console.WriteLine("Construtor Base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor Derivada1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor Derivada2");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();
        }
    }
}
