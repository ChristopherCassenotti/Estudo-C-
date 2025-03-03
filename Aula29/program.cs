using System;

namespace Aula29
{
    static public class Jogador
    {
        static public int energia;
        static public string nome;
        static public bool status;

        static public void iniciar(string n, int e, bool s)
        {
            nome = n;
            energia = e;
            status = s;
        }
        static public void info()
        {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Status jogador: {0}\n", status);
        }
    }

    class Inimigo{
        static public bool alerta;
        public string nome;

        public Inimigo(string n){
            alerta = false;
            nome=n;
            }

        public void info(){
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("-------------------------");
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jogador.iniciar("Bruno", 200, true);
            Jogador.info();

            Inimigo i1 = new Inimigo("Mandrake");
            Inimigo i2 = new Inimigo("Proerd");
            Inimigo i3 = new Inimigo("Tigrinho");

            Inimigo.alerta=true;

            i1.info();
            i2.info();
            i3.info();
        }
    }
}
