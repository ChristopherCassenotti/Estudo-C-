using System;

namespace Aula04
{
    class Program
    {
        static int num2 = 10;//Var global (funciona em qualquer void)
        static void Main(string[] args)
        {
            int num = 0;//Var local (só funciona dentro de sua void)
            Console.Write(num2);
        }
    }
}