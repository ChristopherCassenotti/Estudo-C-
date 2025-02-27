using System;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            float v1, v2 , result;
            Console.WriteLine("Digite o primeiro número: ");
            v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            v2 = float.Parse(Console.ReadLine());

            result = soma(v1,v2);

            Console.WriteLine("A soma de {0} e {1} é {2}", v1 , v2 , result);
        }

        static float soma(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }// static (void,int,float,string...) = function js

    }
}