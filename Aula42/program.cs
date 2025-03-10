using System;
using Internal;

namespace Aula42
{
    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor){
            this.marca=marca;
            this.modelo=modelo;
            this.cor=cor;
        }

        public void info(){
            Console.WriteLine("Modelo: {0}  Cor: {1}   Marca: {2}",this.modelo, this.cor, this.marca);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1;

            c1.info();
        }
    }
}
