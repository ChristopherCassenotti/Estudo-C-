using System;

namespace Aula43
{
    struct Carro
    {
        public string modelo;
        public string cor;

        public void info(){
            Console.WriteLine("Modelo: {0}",this.modelo);
            Console.WriteLine("Cor...: {0}", this.cor);
            Console.WriteLine("------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros = new Carro[4];

            carros[0].modelo ="HRV";
            carros[0].cor ="Prata";

            carros[1].modelo ="Golf";
            carros[1].cor = "Azul";

            carros[2].modelo ="Jetta";
            carros[2].cor = "Branco";

            carros[3].modelo ="Skyline";
            carros[3].cor = "Preto";

            for(int i = 0; i < carros.Length ; i++){
                carros[i].info();
            }
        }
    }
}
