using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }
    }
}
