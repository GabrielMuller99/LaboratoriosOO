using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_exerc03
{
    class JogoDigital : Produto
    {
        public string Plataforma { get; private set; }

        public JogoDigital(string titulo, double preco, string plataforma) : base(titulo, preco)
        {
            Plataforma = plataforma;
        }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} para {Plataforma}");
        }
    }
}
