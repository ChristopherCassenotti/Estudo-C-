using System;

namespace Aula36
{

    class Base
    {//base
        public Base()
        {
            Console.WriteLine("Construtor Base");
        }

        virtual public void info(){
            Console.WriteLine("Base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor Derivada1");
        }

        override public void info(){
            Console.WriteLine("Derivada 1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor Derivada2");
        }

        override public void info(){
            Console.WriteLine("Derivada 2");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Base Ref;

            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();

            Ref = derivada2;

            Ref.info();
        }
    }
}
