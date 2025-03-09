using System;
using System.Collections.Generic;

namespace Aula53
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Avião");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Skate");

            //veiculos.Clear();
            veiculos[15] = "Bicicleta";
            //veiculos.Remove(20);

            string chave = "Bicicleta";
            if (veiculos.ContainsValue(chave))
            {
                Console.WriteLine("Chave está na coleção: {0}", chave);
            }
            else
            {
                Console.WriteLine("Chave não está na coleção: {0}", chave);
            }

            Dictionary<int,String>.ValueCollection valores = veiculos.Values;

            foreach (string v in valores)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
            

        }
    }
}
