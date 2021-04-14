using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public PessoaJuridica(long id, string nome, string cnpj, Endereco endereco, string email) : base(id, nome, endereco, email)
        {
            CNPJ = cnpj;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"Fornecedor: {Nome}");
            Console.WriteLine($"--ID: {Id}");
            Console.WriteLine($"--CNPJ: {CNPJ}");
            Console.WriteLine($"--Endereço: {Endereco}");
            Console.WriteLine($"--Email: {Email}");
        }
    }
}
