using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto jogo1 = new JogoDigital("FIFA 2021", 350, "PS5");
            Produto jogo2 = new JogoDigital("Persona 5 Strikers", 300, "PS5");
            Produto livro1 = new Livro("Harry Potter", 40, "J. K. Rowling");
            Produto livro2 = new Livro("Game of Thrones", 50, "George R. R. Martin");

            Produto[] produtos = { jogo1, jogo2, livro1, livro2 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("------------------------------");
                Console.ReadLine();
            }
        }
    }
}
