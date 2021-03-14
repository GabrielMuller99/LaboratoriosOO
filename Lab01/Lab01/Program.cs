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
            Console.WriteLine("Digite o nome do usuário da academia ACME:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do usuário da academia ACME:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do usuário da academia ACME em METROS:");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso do usuário da academia ACME em KILOS:");
            double peso = Convert.ToDouble(Console.ReadLine());

            Usuario usuario = new Usuario(nome, idade, altura, peso);
            usuario.IMC();

            if (usuario.Ideal == false)
            {
                Console.WriteLine(usuario.Mensagem + "{0}kg e {1}kg", usuario.MetaUm, usuario.MetaDois);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(usuario.Mensagem);
                Console.ReadLine();
            }
        }
    }
}
