using System;

namespace Aula33
{
    class Veiculo
    {// class base
        public int velMax;
        private bool ligado;
        private int rodas;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public void ligar()
        {
            ligado = true;
        }

        public void desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return (ligado ? "sim" : "não");
        }
        public int getRodas()
        {
            return rodas;
        }
        public void setRoda(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 6)
            {
                this.rodas = 6;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

    class Carro : Veiculo //class derivada
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor) : base(4)
        {
            ligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate : Carro
    {
        public int municao;
        public CarroCombate() : base("Carro de Combate", "Verde")
        {
            municao = 100;
            setRoda(6);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("rapido", "vermelho");
            CarroCombate cc1 = new CarroCombate();

            Console.WriteLine("Cor: {0}", c1.cor);
            Console.WriteLine("Nome: {0}", c1.nome);
            Console.WriteLine("Rodas: {0}", c1.getRodas());
            Console.WriteLine("Vel.Máxima: {0}", c1.velMax);
            Console.WriteLine("Ligado: {0}", c1.getLigado());

            Console.WriteLine("------------------------------------------------------");


            Console.WriteLine("Cor: {0}", cc1.cor);
            Console.WriteLine("Nome: {0}", cc1.nome);
            Console.WriteLine("Rodas: {0}", cc1.getRodas());
            Console.WriteLine("Vel.Máxima: {0}", cc1.velMax);
            Console.WriteLine("Munição: {0}", cc1.municao);
            Console.WriteLine("Ligado: {0}", cc1.getLigado());
        }
    }
}
