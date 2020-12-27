using System;

namespace Practica1
{
    class Problema1    
    {
        /* Escribir un probrama que solicite la carga de un numero enre 0 y 999 y 
         * nos muestre un mensaje de cuantos digitos tiene el mismo. Finalizar el programa cuando se cargue el valor 0
         */
        static void Main(string[] args)
        {
            int valor = 0;
            while (valor<=999)
            {
                Console.Write("Introduzca un valor entre 0 y 999 ...: ");
                valor = int.Parse(Console.ReadLine());
                if (valor > 999) Console.WriteLine("Saliendo del programa");
                else if (valor >= 100) Console.WriteLine("El valor introducido posee 3 dígitos");
                else if (valor >= 10) Console.WriteLine("El valor introducido posee 2 digitos");
                else if (valor >= 0) Console.WriteLine("El valor introducido posee 1 digito");
            }
           

        }
    }
}
