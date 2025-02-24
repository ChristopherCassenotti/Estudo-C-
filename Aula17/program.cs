using System;

namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num= {"Carro", "2025", "Honda", "Preto", "0km", "Novo", "Seguro", "R$ 1.000.000", "Macho", "Sigma", "Cromado"};

            int i= 0;
            while(i<num.Length){
                Console.WriteLine(num[i]);
                i++;
            }
        }
    }
}