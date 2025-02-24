using System;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num= {"Carro", "2025", "Honda", "Preto", "0km", "Novo", "Seguro", "R$ 1.000.000", "Macho", "Sigma", "Cromado"};

            for(int i=0 ; i<num.Length ; i++){
                Console.WriteLine(num[i]);
            }

        }
    }
}