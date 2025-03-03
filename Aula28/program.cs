using System;

namespace Aula28
{
    public class Jogador
    {
        public int energia;
        public string nome;
        public bool status;

        public Jogador(){
            energia = 100;
            status = true;
            nome = "Jogador";
        }
        public Jogador(string n){
            energia = 100;
            status = true;
            nome = n;
        }
        public Jogador(string n, int e){
            energia = e;
            status = true;
            nome = n;
        }
        public Jogador(string n, int e, bool s){
            energia = e;
            status = s;
            nome = n;
        }

        public void info(){
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Status jogador: {0}\n", status);
        }
        
        ~Jogador(){
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Gusto", 120, true);
            Jogador j3 = new Jogador("Atr", 30, true);
            Jogador j4 = new Jogador("GS", 40, true);
            Jogador j5 = new Jogador("XAs", 0, false);


            j1.info();
            j2.info();
            j3.info();
            j4.info();
            j5.info();
        }
    }
}
