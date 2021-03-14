using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float altura;
            float peso;

            Console.WriteLine("Digite o nome do usuário da academia ACME:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do usuário da academia ACME:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do usuário da academia ACME em METROS:");
            altura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o peso do usuário da academia ACME em KILOS:");
            peso = Convert.ToSingle(Console.ReadLine());

            
        }
    }
}
