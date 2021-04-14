using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    abstract class Pessoa : IItemRelatorio
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Email { get; set; }

        protected Pessoa(long id, string nome, Endereco endereco, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }

        public abstract void MostrarDescricao();
    }
}
