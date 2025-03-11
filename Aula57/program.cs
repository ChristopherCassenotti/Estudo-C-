using System;
using Internal;
using System.Collections.Generic;

namespace Aula55
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] elo = {"Ferro", "Bronze", "Prata", "Gold"};

            Queue<string> rankQueue = new Queue<string>();

            rankQueue.Enqueue("Ferro");// Add no fim da fila
            rankQueue.Enqueue("Bronze");
            rankQueue.Enqueue("Prata");
            rankQueue.Enqueue("Gold");

            string ferro = "Ferro";
            if (rankQueue.Contains(ferro))
            {
                Console.WriteLine("Elo encontrado {0}", ferro);
            }
            else
            {
                Console.WriteLine("Elo NÃO encontrado {0}", ferro);
            }

            //rankQueue.Clear();
            
            //Console.WriteLine("Primeiro Rank {0}", rankQueue.Dequeue());
            //Console.WriteLine("Primeiro Rank {0}", rankQueue.Peek());

            foreach(string rq in rankQueue){
                Console.WriteLine("Rank {0}", rq);
            }

            Console.WriteLine("Tamanho da Fila: {0}", rankQueue.Count);
            
            while(rankQueue.Count > 0){
                Console.WriteLine(rankQueue.Dequeue());
            }
        }
    }
}
