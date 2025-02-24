using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3,3];
            int[,] num = new int [2,2] { {10 , 20} , {30 , 40}};

            n[0,0]= 1; n[0,1]= 2; n[0,2]= 3;
            n[1,0]= 4; n[1,1]= 5; n[1,2]= 6;
            n[2,0]= 7; n[2,1]= 8; n[2,2]= 9;

            Console.WriteLine(n[1,1]);
            Console.WriteLine(num[1,1]);
        }
    }
}