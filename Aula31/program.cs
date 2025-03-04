using System;
using Aula31;

namespace Aula31
{
    class Jogador
    {
        private int energia;
        private string nome;

        public Jogador(string nome){
            this.nome = nome;
            energia = 100;
        }
        //maneira de acessar membros private
        public int getEnergia(){
            return energia;
        }

        public string getNome(){
            return nome;
        }
        //maneira de mudar membros private
        public void setEnergia(int e){
            if(e<0){
                if(energia+e < 0){
                    energia=0;
                }else{
                    energia+=e;
                }
            }else if(e>0){
                if(energia+e > 100){
                    energia=100;
                }else{
                    energia+=e;
                }
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Jogador j1 = new Jogador("BRAZ");

        j1.setEnergia(-120);

        Console.WriteLine("Nome : {0}", j1.getNome());
        Console.WriteLine("Energia : {0}", j1.getEnergia());
    }
}

