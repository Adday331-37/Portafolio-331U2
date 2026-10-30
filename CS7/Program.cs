using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
// Espacio de nombres
namespace CS7
{
    // Clase principal
    class Program
    {
        // Funcion principal
        static void Main(string[] args)
        {
            // Bloque de la funcion
            // Sesion 15: Funciones 
            /*
            Funcion: Bloque de instrucciones para realizar una tarea especifica.
            Sintaxis
            tipo_dato_devuelto identificador_funcion(parametros)
            {
                Bloque de instrucciones           
            }
            Nota 1: Los parametros se definen incluyendo tipo de dato.
            Nota 2: Los parametros van separados por comas.
            Sintaxis: Invocacion funcion
            identificador_funcion()
            */
            // Ejemplo 1: Funcion vacia sin parametros
            void Saludar()
            {
                string salon = "Exactas 331";
                Console.WriteLine($"Hola, {salon}!");
            }
            // Invocacion
            Saludar();
            // Ejercitacion
            // 1. Definir e invocar una funcion sin parametros para imprimir: nombre, clave y salon.
            void nombre()
            {
                string nombre = "Adday";
                string clave = "37";
                string salon2 = "Exactas 331";
                Console.WriteLine($"{nombre}, {clave}, {salon2}");
            }
            nombre();
            // 2. Definir e invocar una funcion sin parametros para desplegar el horario de hoy.
            void horario()
            {
                string cl1 = "7:00 Calculo";
                string cl2 = "7:50 Formacion Humana";
                string cl3 = "8:40 Programacion";
                string cl4 = "9:30 Recreo";
                string cl5 = "9:50 Psicologia";
                string cl7 = "10:40 idiomas";
                string cl8 = "11:30 Recreo";
                string cl9 = "11:50 Dibujo tecnico";
                string cl10 = "1:30 Salida";
                Console.WriteLine($"horario: {cl1}, {cl2}, {cl3}, {cl4}, {cl5}, {cl7}, {cl8}, {cl9}, {cl10}.");
            }
            horario ();
            // Sesion 16: Funcion con parametros
            // return: Palabra reservada para terminar una funcion y devolver una expresion
            // Ejemplo 1: Doble
            int CalcularDoble(int numero)
            {
                int resultado = 2 * numero;
                return resultado;
            }
            // Invocacion
            int devolucion;
            devolucion = CalcularDoble(3);
            
        // Realizar una funcion que devuelva la evaluacion de la siguiente expresion: f(x) = 4x - 7/5
        double f(double x)
        {
            double y;
            y = 4 * x - 7 / 5D;
            return y;
        }
        double d;
        d = f(0);
        Console.WriteLine($"");
        } // Termino de la funcion principal
    } // Termino de la clase principal
} // Termino del espacio de nombres 