using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ler_Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = File.ReadAllLines(@"H:\IESB\Git\Labs\Ler_Arquivo\ListaEspera.txt");

            foreach (string linha in linhas)
            {
                string[] linhaArray = linha.Split(';');
                for (int i = 0; i < linhaArray.Length; i++)
                {
                    linhaArray[i] = linhaArray[i].Trim();
                }

                Console.WriteLine($"Nome: {linhaArray[0]}");
                Console.WriteLine($"Especialidade: {linhaArray[1]}");
                Console.WriteLine("**********************");
            }
            Console.ReadKey();
        }
    }
}
