using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            List<int> listaNumeros = new List<int>();
            Random random = new Random();
            int nuevoNumero;


            do            // 2. Llenar la lista hasta cumplir la condición (> 98)
            {
                nuevoNumero = random.Next(101);
                listaNumeros.Add(nuevoNumero);

                Console.WriteLine($"Número generado: {nuevoNumero}");

            } while (nuevoNumero <= 98);

            Console.WriteLine("\n--- Generación finalizada ---");


            int maximo = listaNumeros[0];

            foreach (int num in listaNumeros)
            {
                if (num > maximo)
                {
                    maximo = num;
                }
            }

            Console.Write("\nLista generada: ");

            foreach (int num in listaNumeros)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"El número más grande sin ordenar la lista es: {maximo}");
            Console.WriteLine($"El número más grande ordenando la lista es: {listaNumeros.Max()}");
        }
    }
}
   