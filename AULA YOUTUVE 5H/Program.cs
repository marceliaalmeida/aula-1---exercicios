using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_YOUTUVE_5H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DataAnoAniversario = 1986;
            string corFavorita = "roxo";
            float peso = 89.7f;
            bool autismo = true;

            var meutexto = "Hello World - Marcélia";
            Console.WriteLine(DataAnoAniversario);
            Console.WriteLine(corFavorita);
            Console.WriteLine(peso);
            Console.WriteLine(autismo);

            peso = 75.5f;
            corFavorita = "preto";
            Console.WriteLine(peso);
            Console.WriteLine(corFavorita);

            dynamic peso1 = 77.6f;
            dynamic corFavorita1 = "rosa";
            corFavorita1 = 123;
            peso1 = "mais magra";


            Console.ReadLine(); 
        }
        
    }
}
