using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Fila
    {
		private int primeiro;
		private int ultimo;
		private int[] elementos;

		public Fila(int numElementos)
		{
			elementos = new int[numElementos];
			primeiro = 0;
			ultimo = -1;
		}

		public void InserirNaFila(int elemento)
		{
			if (ultimo == elementos.Length - 1)
			{
				Console.WriteLine("A fila está cheia, não é possível inserir.");
				return;
			}
			else
			{
				ultimo++;
				elementos[ultimo] = elemento;
				Console.WriteLine("Elemento inserido");
				return;
			}
		}

		public void RetirarDaFila()
        {
			if (ultimo == -1)
            {
				Console.WriteLine("A fila está vazia.");
				return;
            }
            else
            {
				primeiro++;

                if (primeiro > ultimo)
                {
					primeiro = 0;
					ultimo = -1;
                }

				Console.WriteLine("Elemento excluído com sucesso.");
				return;
            }
        }

		public void ConsultarFila()
        {
			if (ultimo == -1)
			{
				Console.WriteLine("A fila está vazia.");
				return;
			}
            else
            {
				Console.WriteLine(elementos[primeiro]);
				return;
            }
		}

		public void ExibirFila()
        {
			if (ultimo == -1)
			{
				Console.WriteLine("A fila está vazia.");
				return;
			}
            else
            {
                for (int i = primeiro; i < ultimo; i++)
                {
					Console.WriteLine($"{elementos[i]} ");
                }
				return;
            }
		}
	}
}
