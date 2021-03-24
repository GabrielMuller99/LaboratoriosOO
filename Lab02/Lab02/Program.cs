using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Corrente bobNelson = new Corrente("12345-6", "Bob Nelson");
            Poupanca testolfo = new Poupanca("71717-1", "Testolfo Rocha");
            Corrente lisaLeite = new Corrente("65432-1", "Lisa Leite");

            bobNelson.Depositar(5000);
            lisaLeite.Depositar(2000);
            testolfo.Depositar(1500);

            bobNelson.tranferirCorrente(testolfo, 600);

            lisaLeite.Sacar(250);
            lisaLeite.tranferirCorrente(testolfo, 400);

            testolfo.tranferirPoupanca(bobNelson, 1000);

            bobNelson.Sacar(900);
            bobNelson.tranferirCorrente(lisaLeite, 1500);

            testolfo.tranferirPoupanca(lisaLeite, 1200);

            bobNelson.Sacar(2000);

            lisaLeite.Depositar(100);

            testolfo.tranferirPoupanca(bobNelson, 700);

            Console.WriteLine($"Saldo de {bobNelson.Nome}: {bobNelson.Saldo}R$");
            Console.WriteLine($"Saldo de {testolfo.Nome}: {testolfo.Saldo}R$");
            Console.WriteLine($"Saldo de {lisaLeite.Nome}: {lisaLeite.Saldo}R$");
            Console.ReadLine();
        }
    }
}
