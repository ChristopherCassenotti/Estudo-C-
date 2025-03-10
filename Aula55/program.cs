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

            carros.CopyTo(carros2,0);

            foreach (string c in carros2)
            {
                Console.WriteLine("Carro: {0}", c);
            }

            string car = "Dodger";
            int pos = 0;
            pos=carros.IndexOf(car);
            Console.WriteLine("Carro {0} está na pos {1}", car, pos);
        }
    }
}
