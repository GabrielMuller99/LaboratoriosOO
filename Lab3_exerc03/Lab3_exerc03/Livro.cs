using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_exerc03
{
    class Livro : Produto
    {
        public string Autor { get; private set; }

        public Livro(string titulo, double preco, string autor) : base(titulo, preco)
        {
            Autor = autor;
        }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} escrito por {Autor}");
        }
    }
}
