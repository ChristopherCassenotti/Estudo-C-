using System;

namespace Aula12{
    class Program
    {
        static void Main(string[] args){

            int tempo = 0;
            char escolha;
            string automovel = " ";

            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha){
                case 'a':
                case 'A':
                    tempo = 50;
                    automovel = "Avião";
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    automovel = "Carro";
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    automovel = "Ônibus";
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if(tempo<0){
                Console.WriteLine("Essa opção não está disponível");
            }
            else{
                Console.WriteLine("Vôce selecionnou o {0}, sua viagem demorará {1} minutos", automovel ,tempo);
            }
        }
    }
}