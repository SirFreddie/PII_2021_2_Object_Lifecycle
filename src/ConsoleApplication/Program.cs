//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // Se puede iterar para crear multiples objetos.
            // Al intentar crear 10.000.000 instancias no se llega a crear dicha cantidad. 
            // Se crea una cantidad limitada, a mi ver, para gestionar el uso de memoria en caso de que este limitada.
            /*
            for(int i = 0; i < 10000000; i++)
            {
                Train train = new Train("TrainX");
            }
            */
            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            // Para t1 == t2, retornara falso, son dos objetos iguales pero no identicos, comparten parametros unicamente.
            // Para t2 == t3, retornara falso, son dos objetos diferentes dada su asignacion, y no comparten parametros.
            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);
            Console.WriteLine(Train.Count);
        }
    }
}