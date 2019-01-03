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

           // Console.WriteLine("Hola mundo");

            //Console.ReadKey();

            /*Tipos de Datos*/

            int i = 0;
            Decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            String cadena = "Hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;



                    /*Conversiones de tipo*/
             String cadena2 ="1234";
            i = Convert.ToInt32(cadena2);
            Console.WriteLine(i);
            Console.ReadKey();

                    /*Condicionales*/
              int valor1=0,valor2=0;
            String cadenaC;
            Console.WriteLine("Dame el primer valor");
            cadenaC= Console.ReadLine();
            valor1= Convert.ToInt32(cadenaC);
            Console.WriteLine("Dame el segundo valor");
            cadenaC= Console.ReadLine();
            valor2= Convert.ToInt32(cadenaC);
            if (valor1 <= valor2)
                {
                    if (valor1==valor2)
                     Console.WriteLine("El valor 1 es igual al 2");
                    else
                    Console.WriteLine("El valor 2 es mayor al 1");
                }
            else
                Console.WriteLine("El valor 1 es mayor o igual al 2");

            Console.ReadKey();
            /**/
         }
    }
}
