using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_exerc05
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(string nome, double preco) : base(nome, preco)
        {
        }

        public override void ImprimirNome()
        {
            base.ImprimirNome();
        }

        public override void ImprimirPreco()
        {
            base.ImprimirPreco();
        }
    }
}
