using System;

namespace Aula44
{
    class Galinha
    {
        private string nomeGalinha;
        private int qntdOvo;
        private static int totalOvos;
        public Galinha(string nomeGalinha)
        {
            this.nomeGalinha = nomeGalinha;
            qntdOvo = 0;
        }

        public Ovo botar()
        {
            qntdOvo++;
            totalOvos++;
            return new Ovo(qntdOvo, nomeGalinha);
        }
        public static void ControleOvos(){
            Console.WriteLine("Total de ovos: {0}", totalOvos);
        }
    }

    class Ovo
    {
        private int qntdOvo;
        private string minhaGalinha;
        public Ovo(int qntdOvo, string minhaGalinha)
        {
            this.minhaGalinha = minhaGalinha;
            this.qntdOvo = qntdOvo;
            Console.WriteLine("Ovo criado: {0} - {1}\n", this.qntdOvo, this.minhaGalinha);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Galinha g1 = new Galinha("Franga");
            Galinha g2 = new Galinha("Alberte");
            Galinha g3 = new Galinha("Cassio");

            g1.botar();
            g1.botar();

            g2.botar();
            g2.botar();
            g2.botar();
            g2.botar();
            g2.botar();

            g3.botar();
            g3.botar();
            g3.botar();

            Galinha.ControleOvos();
        }
    }
}
