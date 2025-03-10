using System;

namespace Aula25
{
    public class Jogador
    {
        public int energia=100;
        public bool vivo=true;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();

            j1.energia = 50;

            Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
            
        }
    }
}
//[ModificadorClasse] class NOME_DA_CLASSE
//{
//Variáveis / propriedades 
//[EspecificadorAcesso] tipo NOME_PROPRIEDADE;

//Métodos 
//[EspecificadorAcesso] retorno NOME_MÉTODO([arg1,...])
// {
//Corpo do método 
//}
//}

//ModificadorClasse: Define a visibilidade da classe 

//public: Pública, sem restrição de visualização 

//abstract: Classe-Base para outras classes, não podem ser instanciados a objetos desta classe 

//sealed: Classe não pode ser herdada 

//static: Classe não permite a instanciação de objetos e seus membros devem ser static 

//EspecificadorAcesso: Onde um menbro da classe pode ser acessado 

//public: Sem restrição de acesso 

//private: Só podem ser acessador pela própria classe 

//protected: Podem ser acessados na própria classe e nas classes 

//derivadas 

//abstract: Os métodos não tem implementação somente os cabeçalhos 

//sealed: O médodo não pode ser redefinido 

//virtual: o método pode ser redefinido em uma classe derivada 

//static: O método pode ser chamado mesmo sem a instanciação de um objeto