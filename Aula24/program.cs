using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(6 , 3);
        }

        static void soma(params int[]n)
        {
            int res = 0;

            if(n.Length < 1){
                Console.WriteLine("Não existe valores para serem somados");
            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para soma: {0}",n[0]);
            }else{
                foreach(int num in n){
                    res+=num;
                }
                Console.WriteLine("A soma dos valores é igual a : {0}",res);
            }


        }
    }
}
