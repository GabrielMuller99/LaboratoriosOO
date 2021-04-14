﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01
{
    class Endereco
    {
        public long Numero { get; set; }
        public string Rua { get; set; }
        public Bairro Bairro { get; set; }
        public Cidade Cidade { get; set; }

        public Endereco(long numero, string rua, Bairro bairro, Cidade cidade)
        {
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
