﻿using System;
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
            Console.WriteLine("La  variable resltado contiene:  " + resultado);
            Console.ReadKey();

            String entrada = "";

            Console.WriteLine("Escribe tu nombre");
            entrada = Console.ReadLine();
            Console.WriteLine("Hola {0}, ¿Como estas hoy?", entrada);
            Console.ReadKey();

            //Setencias de Condiciones
            // IF = si
            //IF - Else

            if (10 < 5)
            {

                Console.WriteLine("la sentencia es verdadera");
            }
            else
                Console.WriteLine("la sentencia es falsa");


            Console.ReadKey();

            //Operadores logicos
            // Y = && 
            // O = ||
            // NOT = ! 

            int a = 0;
            int b = 5;
            int X = 10;
            int y = 10;

            if (x == 10 || y == 10)
            {

                Console.WriteLine("X  y Y son iguales");

            }

            Console.ReadKey();

            // switch y case

            String valors = "a";
            
            switch (valors) {

                case "a":
                    Console.Write("Entro en el case 1");
                    break;
                case "b":
                    Console.Write("Entro en el case 2");
                    break;
                case "c":
                    Console.Write("Entro en el case 3");
                    break;
                default:
                    Console.Write("Entro en el case default");
                    break;
            }
            Console.ReadKey();

            // Incremento y decremento en variables
            int numero = 0;
            numero++;//aumenta el valor en 1
            numero--;//disminuye el numero de 1 a 1


            // while 

            while(numero<10)
            {
                Console.WriteLine("Hola Mundo");
                numero++;
            }


            Console.ReadKey();

            //DO-While 
            int num = 0;
            do {

                Console.WriteLine("hola mundo con do-While \n");
                num++;
            } while (num < 10);

            Console.ReadKey();

            //For 

            for(int cont=0; cont < 10; cont++)
            {
                Console.WriteLine("Vueltas del for {0}", cont);
            }

            Console.ReadKey();

            // Funciones 
            /*
             *Tipos de funciones 
             * devuelven valores
             * reciben valores
             * reciben valores y devuelven valores
             
             */

          
        }
        public void MostrarHola()
        {

        }

    }
}

