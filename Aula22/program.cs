using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            dobrar(ref num);
            Console.WriteLine(num);
        }

        static void dobrar(ref int valor)
        {
            valor*=2;
        }
    }
}