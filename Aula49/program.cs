using System;

namespace Aula49
{

    class Program
    {
        static void Main(string[] args)
        {
            int res=0;
            if(args.Length >0){
                Console.WriteLine("Qtde {0}", args.Length);
                for(int i=0; i < args.Length ; i++){
                    res += Int32.Parse(args[i]);
                }
                Console.WriteLine(res);
            }else{
                Console.WriteLine("Não foi passado");
            }
        }
    }
}
