using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();
            VerificaPalindroma(palavra);
            Console.ReadKey();
        }

        static void VerificaPalindroma(string palavra)
        {
            char[] letras = palavra.ToCharArray();
            Array.Reverse(letras);
            string palavraReversa = new string(letras);

            if (palavra.ToLower() == palavraReversa.ToLower())
            {
                Console.WriteLine($"{palavra} é Palíndroma");
            }
            else
            {
                Console.WriteLine($"{palavra} não é Palíndroma");
            }
        }
    }
}
