using System;

//Organiza as class, colocando elas em escopos separados
namespace Aula52
{
    namespace Cal1
    {
        class Area
        {
            public static float Quad(float bas, float altura)
            {
                if (bas == 0 || altura == 0)
                {
                    throw new Exception("Base ou altura não pode ser igual a 0");
                }
                return bas * altura;

            }
        }
    }
    
    namespace Cal2
    {
        class Area
        {
            public static float Quad(float bas, float altura)
            {
                if (bas == 0 || altura == 0)
                {
                    throw new Exception("Base ou altura não pode ser igual a 0");
                }
                return bas * altura;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float area = 0;

            //tratamento de erro sem travar o programa
            try
            {
                area = Cal1.Area.Quad(0F, 0F);
                Console.WriteLine("Area do quad: {0}", area);
            }
            //Está recebendo o erro dentro de um elemento
            catch (Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
                Console.WriteLine("Tipo: {0}", e.GetType());
            }
            finally
            {
                Console.WriteLine("Fim do calculo");
            }
        }
    }
}
