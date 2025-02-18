using System;

namespace Aula08{
    class Program
    {
        static void Main(string[] args){
            int num = 10;
            int num2 = 10;

            num= num>>2;//bitwise >> corta o valor pela metade
            num2= num2<<11;//bitwise << dobra o valor

            Console.WriteLine(num);
            Console.WriteLine(num2);
        }
    }
}