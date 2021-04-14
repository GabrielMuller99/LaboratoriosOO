using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class Cadastro
    {
        public List<PessoaFisica> Clientes { get; set; }
        public List<PessoaJuridica> Fornecedores { get; set; }

        public Cadastro()
        {
            Clientes = new List<PessoaFisica>();
            Fornecedores = new List<PessoaJuridica>();
        }

        public void relacionarClientes()
        {
            if (Clientes != null)
            {
                foreach (PessoaFisica cliente in Clientes)
                {
                    cliente.MostrarDescricao();
                    Console.WriteLine();
                }
            }
        }

        public void relacionarFornecedores()
        {
            if (Fornecedores != null)
            {
                foreach (PessoaJuridica fornecedor in Fornecedores)
                {
                    fornecedor.MostrarDescricao();
                    Console.WriteLine();
                }
            }
        }

        public void AdicionarCliente(PessoaFisica cliente)
        {
            Clientes.Add(cliente);
            Console.WriteLine($"{cliente.Nome} cadastrado com sucesso!");
        }

        public void RemoverCliente(PessoaFisica cliente)
        {
            if (Clientes != null)
            {
                Clientes.Remove(cliente);
                Console.WriteLine($"{cliente.Nome} removido com sucesso!");
            }
            else
            {
                return;
            }
        }

        public void AdicionarFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedores.Add(fornecedor);
            Console.WriteLine($"{fornecedor.Nome} cadastrado com sucesso!");
        }

        public void RemoverFornecedor(PessoaJuridica fornecedor)
        {
            if (Fornecedores != null)
            {
                Fornecedores.Remove(fornecedor);
                Console.WriteLine($"{fornecedor.Nome} removido com sucesso!");
            }
            else
            {
                return;
            }
        }
    }
}
