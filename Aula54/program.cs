using System;
using Internal;
using System.Collections.Generic;

namespace Aula54
{
    class Program
    {
        static void Main(string[] args)
        {

        LinkedList<string> transportes = new LinkedList<string>();

        transportes.AddFirst("Carro");//Inicio
        transportes.AddFirst("Moto");
        transportes.AddFirst("Aviao");


        transportes.AddLast("Skate");//Final

        LinkedListNode<string> nod;
        nod = transportes.FindLast("Moto");
        transportes.AddBefore(nod, "Cavalo");//antes

        //transportes.Clear();

        if(transportes.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Encontrado");
        }

        transportes.Remove("Moto");


        foreach(string t in transportes){
            Console.WriteLine("Transporte {0}",t);
        }
        }
    }
}
