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
        public float Altura;
        public float Peso;
        public float Imc;
        public float Meta;

        public Usuario(string nome, int idade, float altura, float peso)
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
                Console.WriteLine("Parabéns — você está em seu peso normal!");
            }
            else if (Imc >= 25 && Imc <= 29.9)
            {
                Console.WriteLine("Você está acima de seu peso (sobrepeso).");
            }
            else if (Imc >= 30 && Imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau I.");
            }
            else if (Imc >= 35 && Imc <= 39.9)
            {
                Console.WriteLine("Obesidade grau II.");
            }
            else if (Imc >= 40)
            {
                Console.WriteLine("Obesidade graus III e IV.");
            }
        }
    }
}
