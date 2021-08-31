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
            for (int i = 0; i < 10000000; i++) {
                Train t = new Train("Train n° " + i);
                if (i % 100000 == 0) {
                    Console.WriteLine("Trenes creados: " + i);
                }
            }
            
            Console.WriteLine("En memoria hay " + Train.Count + " trenes creados.");
            Console.WriteLine("Son menos ya que los creados hace más tiempo ya fueron recogidos por el Garbage Collector. Cada vez que este proceso destruye un objeto, llama a su destructor, que altera el valor de la variable de clase. Como el GC es controlado por el CRL y no por el programador, el momento de su recolección puede variar de una ejecución a otra.");
            Console.WriteLine();

            Train t1 = new Train("Last train to London");
            Train t2 = new Train("Last train to London");
            Train t3 = new Train("Runaway train");

            Console.WriteLine("t1 == t2: " + (t1 == t2) + " (porque los objetos a pesar de ser iguales, son dos objetos y no uno)");
            Console.WriteLine("t2 == t3: " + (t2 == t3) + " (porque los valores de sus propiedades son distintos)");
        }
    }
}