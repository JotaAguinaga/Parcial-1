using System;
using System.Globalization;
using System.Text;

namespace TemperaturasSemana
{
    class Temperaturas
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            double suma = 0;
            double promedio;
            int diasArriba = 0;
            int diasAbajo = 0;

            Console.WriteLine("Ingrese las temperaturas diarias de la semana:");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                bool valido = false;
                while (!valido)
                {
                    Console.Write($"Temperatura del día {i + 1}: ");
                    string entrada = Console.ReadLine();

                    if (double.TryParse(entrada, out double temp))
                    {
                        temperaturas[i] = temp;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Ingrese un número (use coma para decimales).");
                    }
                }
            }

            // Calcular promedio
            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
            }

            promedio = suma / temperaturas.Length;

            // Contar días arriba y abajo del promedio
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > promedio)
                    diasArriba++;
                else if (temperaturas[i] < promedio)
                    diasAbajo++;
            }

            Console.WriteLine($"Promedio semanal: {promedio:F1}°C");
            Console.WriteLine($"Días por encima del promedio: {diasArriba}");
            Console.WriteLine($"Días por debajo del promedio: {diasAbajo}");
        }
    }
}
