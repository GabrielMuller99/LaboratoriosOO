using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public bool VIP { get; set; }

        public PessoaFisica(long id, string nome, string cpf, Endereco endereco, bool vip, string email) : base(id, nome, endereco, email)
        {
            CPF = cpf;
            VIP = vip;
        }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"Cliente: {Nome}");
            Console.WriteLine($"--ID: {Id}");
            Console.WriteLine($"--CPF: {CPF}");
            Console.WriteLine($"--Endereço: {Endereco}");
            Console.WriteLine($"--VIP: {VIP}");
            Console.WriteLine($"--Email: {Email}");
        }
    }
}
