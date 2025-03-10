using System;
using Internal;
using System.Collections.Generic;

namespace Aula55
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> carros = new List<string>();
            string[] carros2 = new string[6];

            carros.Add("Golf");
            carros.Add("Honda");
            carros.Add("Uno");
            carros.Add("Dodger");
            carros.Add("Uno");

            //carros2.AddRange(carros);

            //carros.Clear();

            if (carros.Contains("Gol"))
            {
                Console.WriteLine("Está na Lista");
            }
            else
            {
                Console.WriteLine("Não está na lista");
            }
            
            carros.RemoveAt(2);
            
            carros.CopyTo(carros2, 0);

            carros.Insert(1, "Astra");

            int pos2 = carros.LastIndexOf("Uno");

            foreach (string c in carros)
            {
                Console.WriteLine("Carro: {0}", c);
            }


            string car = "Dodger";
            int pos = 0;
            pos = carros.IndexOf(car);
            Console.WriteLine("Carro {0} está na pos {1}", car, pos);
            Console.WriteLine("Ultimo Uno está na pos {0}", pos2);
        }
    }
}
