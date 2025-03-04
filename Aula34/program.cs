using System;

namespace Aula34
{

    class Veiuclo{//base
        public int velAtual;
        private int velMax;
        protected bool ligado;

        public Veiuclo(int velMax){
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }
        public bool getLigado(){
            return ligado;
        }

        public int getVelMax(){
            return velMax;
        }
    }

    class Carro : Veiuclo{//Derivada de Veiculo
        public string nome;

        public Carro(string nome, int velMax):base(velMax){
            this.nome = nome;
            ligado = true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Macquin", 200);

            Console.WriteLine("Nome: {0}", carro.nome);
            Console.WriteLine("Vel.Máxima; {0}", carro.getVelMax());
            Console.WriteLine("Ligado: {0}", carro.getLigado());
        }
    }
}
