using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_pasos_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // este es un programa de prueba
            /*comentarios personalizados*/
            int entero = 5;
            String cadena5 = "C#";
            bool valor = false;


            Console.WriteLine();

            Console.WriteLine("La variable entera tiene: {0}", entero);
            Console.WriteLine("la variable cadena contiene: {0}", cadena5);
            Console.WriteLine("La variable booleana contiene: {0}", valor);
            Console.ReadKey();

            /*Tipos de Datos*/

            int i = 0;
            Decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            String cadena = "Hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;

            //Operadores logicos 
            /*
             = asignacion
             + suma
             - resta
             * multiplicacion
             / division 
             % resto de la division
             == igual 
             != diferente
             < menor que 
             > mayor que 
             >= mayor  o igual
             <= menor o igual 
            */

            Boolean res;
            res = 5 > 4;

            Console.WriteLine(res);
            Console.ReadKey();

            int resultado = 45 % 2;
            Console.WriteLine("La  variable resltado contiene " + resultado);
            Console.ReadKey();

            String entrada = "";

            Console.WriteLine("Escribe tu nombre");
            entrada = Console.ReadLine();
            Console.WriteLine("Hola {0}, ¿Como estas hoy?", entrada);
            Console.ReadKey();

            //Setencias de Condiciones
            // IF = si


        }
    }
}

