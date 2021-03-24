using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Corrente : Conta
    {
        float taxaSaque = 0.37f;

        public Corrente(string identificacao, string nome) : base (identificacao, nome) {}

        public void Sacar(float dinheiro)
        {
            float imposto = dinheiro * taxaSaque;
            if (Saldo <= 0 || dinheiro + imposto > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente para reralizar saque, {Nome}.");
            }
            else
            {
                reduzirSaldo(dinheiro, imposto);
                Console.WriteLine($"{Nome} realizou um saque no valor de {dinheiro}R$, sua conta agora possui {Saldo}R$");
            }
        }

        public void Depositar(float dinheiro)
        {
            aumentarSaldo(dinheiro);
            Console.WriteLine($"{Nome} depositou {dinheiro}R$.");
        }
    }
}
