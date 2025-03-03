using System;

namespace Aula27
{
    public class Jogador
    {
        public int energia;
        public bool vivo = false;
        public string nome;
        public string status;

        public Jogador(string n){
            energia = 100;
            status = Life(vivo);
            nome = n;
        }

        static string Life(bool vivo){
            if(vivo == true){
                return "vivo";
            }else{
                return "morto";
            }
        }

        ~Jogador(){
            Console.WriteLine("Jogador {0} foi deletado", nome);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do jogador 1: ");
            string nomeJ1 = Console.ReadLine();
            Jogador j1 = new Jogador(nomeJ1);

            j1.energia = 50;

            Console.WriteLine("Energia do {1}: {0}  {2}", j1.energia, j1.nome, j1.status);
        }
    }
}
