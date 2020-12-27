using System;

namespace Problema4
{
    class Problema4
    {
        /* Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente la suma
         * de los valores ingresados y su promedio */
        static void Main(string[] args)
        {
            int valor = 0;
            int suma = 0;
            double prom=0;
            for(int i=0; i<10; i++) 
            {
                Console.Write("Introduzca el valor numero " + (i + 1) + " ...: ");
                valor = int.Parse(Console.ReadLine());
                suma = suma+valor;
            }
            prom = suma / 10.0;
            Console.WriteLine();
            Console.WriteLine("La suma de los valores ingresados es...: " + suma);
            Console.WriteLine("El promedio es.........................: " + prom);

        }
    }
}
