using System;

namespace Aula11{
    class Program
    {
        static void Main(string[] args){
            //if
            Console.WriteLine("Digite sua média: ");
            int nota = int.Parse(Console.ReadLine());

            if(nota>7){
                Console.WriteLine("Aprovado");
                return;
            }else{
                Console.WriteLine("Reprovado");
                return;
            }
           
        }
    }
}