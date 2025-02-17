using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args){

            int res = (10 + 5)*2;//operadores matematicos

            Console.WriteLine(res);

            bool res1 = 10>5; // >, <, >=, <=, !=, ==, ===, operadores realcionais

            Console.WriteLine(res1);

            //operadores de incremento: +=, -=, ++(add + 1), =/, =*

             // &, |
             bool res3 =(3>4)&(10>4);
            Console.WriteLine(res3);
        }
    }
}