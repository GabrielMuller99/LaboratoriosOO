using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class Estoque
    {
        public List<ItemLoja> Itens { get; set; }

        public Estoque()
        {
            Itens = new List<ItemLoja>();
        }

        public void MostrarEstoque()
        {
            foreach (ItemLoja item in Itens)
            {
                item.MostrarDescricao();
                Console.WriteLine();
            }
        }

        public void EntradaCaderno(Caderno item, int quantidade)
        {
            item.quantidadeEstoque += quantidade;
            Itens.Add(item);
            Console.WriteLine($"Fornecedor {item.Fornecedor.Nome} entregou {quantidade} cadernos.");
        }

        public void EntradaLivro(Livro item, int quantidade)
        {
            item.quantidadeEstoque += quantidade;
            Itens.Add(item);
            Console.WriteLine($"Fornecedor {item.Fornecedor.Nome} entregou {quantidade} {item.Titulo}.");
        }

        public void VenderCaderno(Caderno item, int quantidade, PessoaFisica cliente)
        {
            if (item.quantidadeEstoque >= quantidade)
            {
                item.quantidadeEstoque -= quantidade;
                Console.WriteLine($"{cliente.Nome} comprou {quantidade} cadernos.");

                if (item.quantidadeEstoque == 0)
                {
                    Itens.Remove(item);
                }
            }
            else
            {
                Console.WriteLine($"Não é possível {cliente.Nome} comprar {quantidade} cadernos, há apenas {item.MostrarQuantidadeEstoque()} restantes");
            }
        }

        public void VenderLivro(Livro item, int quantidade, PessoaFisica cliente)
        {
            if (item.quantidadeEstoque >= quantidade)
            {
                item.quantidadeEstoque -= quantidade;
                Console.WriteLine($"{cliente.Nome} comprou {quantidade} {item.Titulo}.");

                if (item.quantidadeEstoque == 0)
                {
                    Itens.Remove(item);
                }
            }
            else
            {
                Console.WriteLine($"Não é possível {cliente.Nome} comprar {quantidade} {item.Titulo}, há apenas {item.MostrarQuantidadeEstoque()} restantes");
            }
        }
    }
}
