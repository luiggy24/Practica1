using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Problema2
    {
        /* Escribir un programa que solicite la carga de numeros por teclado, obtener su promedio.
         * Finalizar la carga de valores cuando se cargue el valor 0.
         * Cuando la finalizacion depende de algun valor ingresado por el operador conviene el empleo de la 
         * estructura do While, por lo menos cargara un valor (en el caso mas ex    tremo se carga 0, que indica
         * la finalizacion de la carga de valores
        */
        static void Main(string[] args)
        {
            int x = 0;
            int valor = 1;
            double prom = 0.0;
            double acumulador = 0.0;
            while (valor != 0)
            {
                Console.Write("Introduzca el valor " + (x + 1) + "...: ");
                valor = int.Parse(Console.ReadLine());
                if (valor != 0){
                    x++;
                    acumulador += valor;
                }
            }
            prom = acumulador / x;
            Console.WriteLine("El promedio de todos los numeros digitados es...:  " + prom);

        }
    }
}
