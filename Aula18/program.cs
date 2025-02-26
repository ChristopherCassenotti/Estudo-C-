using System;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha= "123";
            string senhauser;
            int tentativas = 0;

            int n = 5;
            //Executa primeiro
            do{
                Console.WriteLine("Digite a senha: ");
                senhauser = Console.ReadLine();
                tentativas++;
                if(senha != senhauser){
                    Console.WriteLine("Senha errada, tente novamente");
                }else{
                    Console.WriteLine("Senha Correta, tentativas {0}", tentativas);
                }
            }while(senha != senhauser);//depois verifica a condição
        }
    }
}