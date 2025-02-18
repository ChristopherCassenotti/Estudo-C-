using System;

namespace Aula09{
    class Program
    {

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
        static void Main(string[] args){

            int ds =(int)DiasSemana.Sexta;

            Console.WriteLine(ds);
        }
    }
}