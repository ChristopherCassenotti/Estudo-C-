using System;

namespace Aula11{
    class Program
    {
        static void Main(string[] args){
            //if
            Console.WriteLine("Digite sua média: ");
            int nota = int.Parse(Console.ReadLine());

            if(nota < 40){
                Console.WriteLine("Reprovado");
                return;
            }else if(nota < 60){
                Console.WriteLine("Recuperação");
                return;
            }else{
                Console.WriteLine("Aprovado");
            }
           
        }
    }
}