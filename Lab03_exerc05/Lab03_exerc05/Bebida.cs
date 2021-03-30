using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_exerc05
{
    class Bebida : ItemMenu
    {
        public string Tamanho { get; private set; }

        public Bebida(string nome, double preco, string tamanho) : base(nome, preco)
        {
            Tamanho = tamanho;
        }

        public override void ImprimirNome()
        {
            Console.WriteLine($"{Nome} {Tamanho}");
        }

        public override void ImprimirPreco()
        {
            switch (Tamanho)
            {
                case "grande":
                    Preco += 7;
                    Console.WriteLine($"{Preco.ToString("C")}");
                    break;

                case "média":
                    Preco += 4;
                    Console.WriteLine($"{Preco.ToString("C")}");
                    break;

                case "pequena":
                    Console.WriteLine($"{Preco.ToString("C")}");
                    break;

                default:
                    break;
            }
        }
    }
}
