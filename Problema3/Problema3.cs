using System;

namespace Problema3
{
    class Problema3
    {
        /* Realizar un programa que permita ingresar el peso (en kilogramos) de piezas.
         * El proceso termina cuando ingresamos el valor 0. Se debe informar:
         * a) Cuantas piezas tienen un peso entre 9.8 y 10.2 kg.
         * b) Cuantas piezas con mas de 10.2 Kg. y
         * C) Cuantas con menos de 9.8 Kg.
         * D) La cantidad de piezas procesadas.
         */
        static void Main(string[] args)
        {
            //Declarando varibles e inicializandolas
            double pesoPieza=1;
            int menores = 0;
            int medianas = 0;
            int mayores = 0;
            int cantPiezas = 0;
            while (pesoPieza != 0)
            {
                
                
                    
                Console.Write("Introducir el valor de la pieza " + (cantPiezas+1) + "....: ");
                pesoPieza = double.Parse(Console.ReadLine());
                if (pesoPieza != 0)
                {
                    cantPiezas++;
                    if (pesoPieza < 9.8) menores++;
                    else if (pesoPieza >= 9.8 && pesoPieza <= 10.2) medianas++;
                    else if (pesoPieza > 10.2) mayores++;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Se han introducido un total de "+cantPiezas+" piezas , de las cuales");
            Console.WriteLine(menores+" piezas poseen un peso menor a 9.8 Kgs");
            Console.WriteLine(medianas+" piezas poseen un peso entre 9.8 y 10.2 Kgs y ");
            Console.WriteLine(mayores+" piezas poseen un peso mayor a 10.2 Kgs");
        }
    }
}
