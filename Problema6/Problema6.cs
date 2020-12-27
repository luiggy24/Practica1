using System;

namespace Problema6
{
    class Problema6
    {
        /* Escribir un probrama que lea 10 numeros enteros y luego muestre cuantos valores
         * ingresados fueron multiplos de 3 y cuantos de 5. Debemos tener en cuenta que hay numeros que son multiplos
         * de 3 y de 5 a la vez */
        static void Main(string[] args)
        {
            int numero = 0;
            int multip3 = 0;
            int multip5 = 0;
            for (int i = 1; i<= 10; i++) 
            {
                Console.Write("Introduzca el valor "+i+" ..: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 3 == 0) multip3++;
                if (numero % 5 == 0) multip5++;
            }
            Console.WriteLine();
            Console.WriteLine(multip3 + " números son multiplos de 3");
            Console.WriteLine(multip5 + " números son multiplos de 5");

        }
    }
}
