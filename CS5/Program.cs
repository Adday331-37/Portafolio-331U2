using System;
// Espacio de nombres
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uninad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Intruccion while 30092026
            // Sintaxis: while
            // Inicializacion;
            // while(expresion)
            // {
            //       Bloque de instrucciones       
            //       iterador;          
            // } 
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente
            // m: variable de control
            int m = 1;  // Inicializacion
            while(m <= 3)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
            // Ejercitacion
            // 1. Definir un ciclo para imprimir tu nombre 5 veces
            // Nota para la expresion, utilizar el operador <.
            // Ciclo ascendente
            int nombre = 1;
            while(nombre < 6)
            {
                Console.WriteLine("Nombre: Adday");
                nombre += 1;
            }
            
            int n = 3;
            while(n >= 1)
            {
                Console.WriteLine($"n ={n}");
                n -= 1;
            }
            // c. Incrementos
            // Secuencia: 3 3 6 9 12 15 18
            int c = 3;
            while(c <= 18)
            {
                Console.WriteLine($"c: {c}");
                c += 3;
            }
            // d, Decrementos
            // Ejercitacion
            // 1. Definir un ciclo para imprimir"331" 8 veces.
            // Nota: Para la solucion, definir un ciclo descendente con decrementos de  2 unidades.
            int b = 16;
            while(b > 0)
            {
                Console.Write("b: 331");
                b -= 2;

            }
            // Adday Sanchez 331-37
            // Actividad 1: Ciclo infinito
            // 1. Definir un ciclo infinito ascendente.
            int a = 1;
            while(a > 0)
            {
                a += 1;
            }
        
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solucion, utilizar el operador de diferencia.
            int de = 1;
            while(de != 2)
            {
                de -= 1;
            }


        } 
    } 
} 