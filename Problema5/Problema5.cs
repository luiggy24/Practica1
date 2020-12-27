using System;

namespace Problema5
{
    class Problema5
    {
        /* Escribir un programa que lea 10 notas de alumnos y nos informe cuantos tienen notas mayores o iguales
         * a 7 y cuantos menores*/
        static void Main(string[] args)
        {
            int mayores = 0;
            int menores = 0;
            int nota = 0;
            for (int i=1; i<=10; i++)
            {
                Console.Write("Introducir nota del estudiante numero "+i+" ...: ");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 7) mayores++;
                else menores++;
            }
            Console.WriteLine();
            Console.WriteLine("Total Aprobados...: " + mayores);
            Console.WriteLine("Total Reprobados..: " + menores);
            
        }
    }
}
