using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    abstract class ItemLoja : IItemRelatorio
    {
        public long Id { get; set; }
        public PessoaJuridica Fornecedor { get; set; }
        public float precoCompra { get; set; }
        public float precoVenda { get; set; }
        public int quantidadeEstoque { get; set; }

        protected ItemLoja(long id, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeEstoque)
        {
            Id = id;
            Fornecedor = fornecedor;
            this.precoCompra = precoCompra;
            this.precoVenda = precoVenda;
            this.quantidadeEstoque = quantidadeEstoque;
        }

        public abstract void MostrarDescricao();
        public abstract int MostrarQuantidadeEstoque();
    }
}
