using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var Primitivas
            
            byte n1 = 100;// de 0 a 255
            int num = 0;// números inteiros ex(-5, 8)
            char letra = 'c';// caractéries somente 1, usa ''
            float valor = 5.5f;// números com vírgula e SEMPRE add "f" no final (valor real) ex = 5.5f
            
            string nome = "Chico"; //armazena escrita completas, usa ""

            var aux = nome;//váriavel que coloca seu prórpio tipo

            Console.Write("Valor da var: " + aux + ".");
        }
    }
}