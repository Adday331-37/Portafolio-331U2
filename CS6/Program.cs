using System;

namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sesion12: Iteradores
             double recorrido = 0;
             double zancadas = 0;
             int hidratacion = 0;
             int hidratacion_total = 2000;
             while(recorrido < 21000)
            {
                recorrido += 0.63;
                zancadas += 1;
                if (hidratacion >= 2000 && hidratacion <= 22000)
                {
                    Console.WriteLine($"Hidratacion: {hidratacion_total}");
                    hidratacion += 1;
                    hidratacion_total += 2000;
                }
                
            }

            Console.WriteLine($"Zancadas necesarias: {zancadas}");
             /* Sintaxis: ciclo for
             for (inicializacion; expresion; iterador;)
             {
                   // Bloque de instrucciones
             }
             */
             // Ejemplo: Secuencia 35-41
             for (int m = 35; m <= 41; m++)
            {
                Console.WriteLine($"m: {m}");
            }
            // 1. Definir un ciclo para la siguiente secuencia: -33, -34, -35, -36, -37, -38, -39.
            Console.WriteLine($"Ciclo 1: Descendente");
            for (int n = -33; n >= -39; n--)
            {
                Console.WriteLine($"n: {n * -1}");
            }
            Console.WriteLine($"Ciclo 2: Ascendente");
            for (int a = 9; a <= 15; a += 1)
            {
                if (a == 13)
                {
                    Console.WriteLine($"a: Omitido");
                }
                Console.WriteLine($"a: {a}");
            }
            int titulo = 1;
            int pagina = 1;
            while (pagina <= 539)
            {
                Console.WriteLine($"Titulo #{titulo}");
                titulo += 1;
                pagina += 88;
            } 
        }
    } 
}
