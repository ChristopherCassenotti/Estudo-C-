using System;


namespace Aula41
{
    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }
    public interface Combate
    {
        void disparar();
    }
    class Carro : Veiculo, Combate
    {
        public bool ligado;
        public string cor;
        public bool atirando;
        public void ligar()
        {
            this.ligado = true;
        }
        public void desligar()
        {
            this.ligado = false;
        }
        public void info()
        {
            this.cor = "Green";
        }
        public void disparar()
        {
            this.atirando = true;
        }
        public Carro()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.desligar();
            c1.info();
            c1.disparar();

            Console.WriteLine("Ligado: {0}", c1.ligado);
            Console.WriteLine("Atirando: {0}", c1.atirando);
            Console.WriteLine("Cor: {0}", c1.cor);
        }
    }
}
