using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArray
{
    internal class Program
    {
        static int[] ListaValores = new int[10];

        static void Main(string[] args)
        {
            ValoresDaLista();

            Console.WriteLine($"Maior valor: {ListaValores.Max()}");
            Console.WriteLine($"Menor valor: {ListaValores.Min()}");
            Console.WriteLine($"Valor médio: {ListaValores.Average()}");
            Console.WriteLine($"Maiores valores na sequência: {ListaValores[8]}, {ListaValores[6]}, {ListaValores[4]}");

            ValoresNegativos();
            ValoresNaSequencia();
            RemoverUmValorDaSequencia();

            Console.ReadKey();
        }

        static void RemoverUmValorDaSequencia()
        {
            var listaRemover = ListaValores.ToList();
            listaRemover.Remove(5);
            ListaValores = listaRemover.ToArray();

            Console.Write($"\nRemover um valor da sequência: ");
            foreach (var item in ListaValores)
            {
                Console.Write($"{item}, ");
            }
        }

        static void ValoresNaSequencia()
        {
            Console.Write($"\nValores da sequência ");
            for (int i = 0; i < ListaValores.Length; i++)
            {
                Console.Write($"{ListaValores[i]}, ");
            }
        }

        static void ValoresNegativos()
        {
            Console.Write($"Valores negativos ");
            for (int i = 0; i < ListaValores.Length; i++)
            {
                if (ListaValores[i] < 0)
                {
                    Console.Write($"{ListaValores[i]},");
                }
            }
        }

        static void ValoresDaLista()
        {
            ListaValores[0] = -5;
            ListaValores[1] = 3;
            ListaValores[2] = 4;
            ListaValores[3] = 5;
            ListaValores[4] = 9;
            ListaValores[5] = 6;
            ListaValores[6] = 10;
            ListaValores[7] = -2;
            ListaValores[8] = 11;
            ListaValores[9] = 1;
        }
    }
}
