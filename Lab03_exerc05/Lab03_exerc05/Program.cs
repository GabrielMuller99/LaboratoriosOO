using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida1 = new Bebida("Coca cola", 3, "pequena");
            Bebida bebida2 = new Bebida("Coca cola", 3, "média");
            Bebida bebida3 = new Bebida("Coca cola", 3, "grande");
            Aperitivo aperitivo1 = new Aperitivo("Coxinha", 3);
            Aperitivo aperitivo2 = new Aperitivo("Batata frita", 6);

            ItemMenu[] lanches = { bebida1, bebida2, bebida3, aperitivo1, aperitivo2 };

            foreach (ItemMenu item in lanches)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("--------------------------");
                Console.ReadLine();
            }
        }
    }
}
