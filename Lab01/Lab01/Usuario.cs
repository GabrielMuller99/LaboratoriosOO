using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Usuario
    {
        public string Nome;
        public int Idade;
        public double Altura;
        public double Peso;
        public double Imc;
        public double MetaUm;
        public double MetaDois;
        public string Mensagem;
        public bool Ideal;

        public Usuario(string nome, int idade, double altura, double peso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
            this.Peso = peso;
        }

        public void IMC()
        {
            Imc = Peso / (Altura * Altura);
                   
            if (Imc >= 18.5 && Imc <=24.9)
            {
                Mensagem = "Parabéns — você está em seu peso normal!";
                Ideal = true;
            }
            else if (Imc >= 25 && Imc <= 29.9)
            {
                Mensagem = "Você está acima de seu peso (sobrepeso), seu peso deve estar entre esses dois: ";
                MetaUm = Altura * Altura * 18.5;
                MetaDois = Altura * Altura * 24.9;
                Ideal = false;
            }
            else if (Imc >= 30 && Imc <= 34.9)
            {
                Mensagem = "Obesidade grau I, seu peso deve estar entre esses dois: ";
                MetaUm = Altura * Altura * 18.5;
                MetaDois = Altura * Altura * 24.9;
                Ideal = false;
            }
            else if (Imc >= 35 && Imc <= 39.9)
            {
                Mensagem = "Obesidade grau II, seu peso deve estar entre esses dois: ";
                MetaUm = Altura * Altura * 18.5;
                MetaDois = Altura * Altura * 24.9;
                Ideal = false;
            }
            else if (Imc >= 40)
            {
                Mensagem = "Obesidade graus III e IV, seu peso deve estar entre esses dois: ";
                MetaUm = Altura * Altura * 18.5;
                MetaDois = Altura * Altura * 24.9;
                Ideal = false;
            }
        }
    }
}
