using System;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo , divisor , quociente , resto;
            
            dividendo = 12;
            divisor = 5;

            quociente=divide(dividendo , divisor , out resto);

            Console.WriteLine("{0}/{1}: quociente={2} e resto={3}", dividendo , divisor , quociente , resto);
        }

        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo/divisor;
            resto = dividendo%divisor;
            return quociente;
        }
    }
}