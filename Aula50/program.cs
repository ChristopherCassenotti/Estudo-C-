using System;

namespace Aula50
{
    class Program
    {
        static void Main(string[] args)
        {
            int res, n1, n2;
            res = n1 = n2 = 0;

            n1 = 10;
            n2 = 0;
            //tratamento de erro sem travar o programa
            try
            {
                res = n1 / n2;
                Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
            }
            //Está recebendo o erro dentro de um elemento
            catch (Exception e){
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Tipo: {0}", e.GetType());
            }
        }
    }
}
