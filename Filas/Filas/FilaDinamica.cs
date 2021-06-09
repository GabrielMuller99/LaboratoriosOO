using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class FilaDinamica
    {
        public Nodo Primeiro { get; set; }
        public int Tamanho { get; set; }
        public Nodo Ultimo { get; set; }

        public FilaDinamica()
        {
            Primeiro = null;
            Tamanho = 0;
            Ultimo = null;
        }

        public void InserirNaFila(int elemento)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.elemento = elemento;
            novoNodo.elo = null;
            Tamanho++;

            if (Ultimo != null)
            {
                Ultimo.elo = novoNodo;
            }

            Ultimo = novoNodo;

            if (Primeiro == null)
            {
                Primeiro = novoNodo;
            }
        }

        public int RetirarDaFila()
        {
            if (Tamanho == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return -1;
            }
            else
            {
                Nodo auxiliar = Primeiro;
                Primeiro = Primeiro.elo;
                Tamanho--;
                return auxiliar.elemento;
            }
        }

        public int ConsultarFila()
        {
            if (Tamanho == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return -1;
            }
            else
            {
                return Primeiro.elemento;
            }
        }

        public void ListarFila()
        {
            Nodo auxiliar = Primeiro;
            Console.Write("Fila: ");

            if (Primeiro == null)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }
            else
            {
                while (auxiliar != null)
                {
                    Console.WriteLine(auxiliar.elemento + " ");
                    auxiliar = auxiliar.elo;
                }
            }
            Console.WriteLine();
        }
    }
}
