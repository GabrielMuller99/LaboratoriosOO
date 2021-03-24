using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Conta
    {
        string identificacao;
        string nome;
        protected float saldo = 0;
        private float transfCorrente = 0.1f;
        private float transfPoupanca = 0.15f;

        public Conta(string identificacao, string nome)
        {
            this.identificacao = identificacao;
            this.nome = nome;
        }

        public string Identificacao { get => identificacao; }
        public string Nome { get => nome; }
        public float Saldo { get => saldo; }

        public void tranferirCorrente(Conta conta, float dinheiro)
        {
            float imposto = dinheiro * transfCorrente;
            if (Saldo <= 0 || dinheiro + imposto > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente para realizar transferência, {Nome}.");
            }
            else
            {
                reduzirSaldo(dinheiro, imposto);
                conta.aumentarSaldo(dinheiro);
                Console.WriteLine($"{Nome} realizou uma transferência no valor de {dinheiro}R$ para a conta de {conta.Nome}");
            }
        }

        public void tranferirPoupanca(Conta conta, float dinheiro)
        {
            float imposto = dinheiro * transfPoupanca;
            if (Saldo <= 0 || dinheiro + imposto > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente para realizar transferência, {Nome}.");
            }
            else
            {
                reduzirSaldo(dinheiro, imposto);
                conta.aumentarSaldo(dinheiro);
                Console.WriteLine($"{Nome} realizou uma transferência no valor de {dinheiro}R$ para a conta de {conta.Nome}");
            }
        }

        public void reduzirSaldo(float dinheiro, float imposto)
        {
            saldo = saldo - dinheiro - imposto;
        }

        public void aumentarSaldo(float dinheiro)
        {
            saldo += dinheiro;
        }
    }
}
