using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    enum EnumGenero
    {
        Ficção,
        Informática,
        Games,
        Negócios
    }

    class Livro : ItemLoja
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public EnumGenero Genero { get; set; }
        public string Editora { get; set; }

        public Livro(long id, string titulo, EnumGenero genero, string autor, string editora, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque) : base(id, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            Titulo = titulo;
            Genero = genero;
            Autor = autor;
            Editora = editora;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"--ID: {Id}");
            Console.WriteLine($"--Genero: {Genero}");
            Console.WriteLine($"--Autor: {Autor}");
            Console.WriteLine($"--Editora: {Editora}");
            Console.WriteLine($"--Fornecedor: {Fornecedor.Nome}");
            Console.WriteLine($"--Preço de compra: {precoCompra}");
            Console.WriteLine($"--Preço de venda: {precoVenda}");
        }

        public override int MostrarQuantidadeEstoque()
        {
            return quantidadeEstoque;
        }
    }
}
