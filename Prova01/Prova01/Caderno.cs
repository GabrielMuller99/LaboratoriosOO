using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class Caderno : ItemLoja
    {
        public int QuantidadeFolhas { get; set; }

        public Caderno(long id, int quantidadeFolhas, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque) : base(id, fornecedor, precoCompra, precoVenda, quantidadeEstoque)
        {
            QuantidadeFolhas = quantidadeFolhas;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"Caderno:");
            Console.WriteLine($"--ID: {Id}");
            Console.WriteLine($"--Quantidade de folhas: {quantidadeEstoque}");
            Console.WriteLine($"--Fornecedor: {Fornecedor}");
            Console.WriteLine($"--Preço de compra: {precoCompra}");
            Console.WriteLine($"--Preço de venda: {precoVenda}");
        }

        public override int MostrarQuantidadeEstoque()
        {
            return quantidadeEstoque;
        }
    }
}
