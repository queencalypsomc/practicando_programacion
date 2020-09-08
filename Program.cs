using System;
using System.IO;

namespace holaMundo
{
    class Program
    {
        static void Main()
        {
            /*Crea un programa que pida al usuario un número entero*/
            int num;

            Console.Write("Introduce un número entero:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El número introducido es {0}.", num);

            /*-----------------------------------------------------------*/
            /*Pedir dos números enteros al usuario*/
            int num1, num2;

            Console.Write("Introduce un número entero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce un número entero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los números introducidos son {0} y {1}.", num1, num2);

            /*-----------------------------------------------------------*/
            /*Crea un programa que pida al usuario un número entero y diga si es par o impar*/

            /*Opción 1 - Hago la operación dentro de la condición*/
            int num;

            Console.Write("Introduce un número entero:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) 
            { 
                Console.WriteLine("El número {0} es par, porque al dividirlo por 2 su resto es {1}.", num, num % 2); 
            }
            else 
            { 
                Console.WriteLine("El número {0} es impar, porque al dividirlo por 2 su resto es {1}.", num, num % 2); 
            }

            /*Opción 2 - Guardo el resultado de la operación en una variable*/
            int num, resto;

            Console.Write("Introduce un número entero:");
            num = Convert.ToInt32(Console.ReadLine());

            resto = num % 2;

            if (resto == 0)
            {
                Console.WriteLine("El número {0} es par, porque al dividirlo por 2 su resto es {1}.", num, resto);
            }
            else
            {
                Console.WriteLine("El número {0} es impar, porque al dividirlo por 2 su resto es {1}.", num, resto);
            }

            /*-----------------------------------------------------------*/
            /*Crea un programa que pida al usuario un número entero 
             * y di si es positivo o cero, o si es negativo*/

            /*Opción 1 - No distingo entre cero y positivo*/
            int numero;

            if (numero >= 0)
            {
                Console.WriteLine("El número {0} es positivo o cero.", numero);
            }
            else
            {
                Console.WriteLine("El número {0} es negativo.", numero);
            }

            /*Opción 2 - Distingo entre cero y positivo*/
            int numero;

            if (numero < 0)
            {
                Console.WriteLine("El número {0} es negativo.", numero);
            }
            else
            {
                if ( numero > 0)
                {
                    Console.WriteLine("El número {0} es positivo.", numero);
                }
                else
                {
                    Console.WriteLine("El número {0} es cero.", numero);
                }                
            }

            /*-----------------------------------------------------------*/
            /*Crea un programa que pida al usuario un número entero 
             * y di si NO es cero*/

            if (numero != 0)
            {
                Console.WriteLine("El número {0} no es cero.", numero);
            }

            /*-----------------------------------------------------------*/
            /*Crea un programa que pida al usuario un número entero 
             * y di si es cero, positivo o negativo y prueba todas las opciones*/
            int numero;

            Console.Write("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else 
            {
                if ((numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("El número es cero.");
                    }
                }
            }
            /*-----------------------------------------------------------*/
            /*Crea un programa que pida al usuario dos números enteros 
             * y los multiplique*/

            int num1, num2, resultado;

            Console.Write("Introduce un número entero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce un número entero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 * num2;

            /* Si los números son AMBOS enteros*/
            if ((num1 > 0) && (num2 > 0))
            {
                if (num1 != 0)
                {
                    if (num2 != 0)
                    {
                        Console.WriteLine("La multiplicación de {0} entre {1} da como resultado {2}.", num1, num2, resultado);
                    }
                    else
                    {
                        Console.WriteLine("La multiplicación por 0 da 0");
                    }
                }
                else
                {
                    Console.WriteLine("La multiplicación por 0 da 0");
                }
            }

            if (num1 < 0)
            {
                Console.WriteLine("El número {0} es un número entero.", num1);
            }

            if (num2 < 0)
            {
                Console.WriteLine("El número {0} no es un número entero.", num2);
            }


            /*-----------------------------------------------------------*/
            /*Crea un programa que pida al usuario dos números enteros 
             * y los divida*/

            int num1, num2, resultado;

            Console.Write("Introduce un número entero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce un número entero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 / num2;

            /* Si los números son AMBOS enteros*/
            if ((num1 > 0) && (num2 > 0))
            {
                if ( num2 != 0 )
                {
                    Console.WriteLine("La división de {0} entre {1} da como resultado {2}.",num1, num2, resultado);
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
            }

            if (num1 < 0)
            {
                Console.WriteLine("El número {0} es un número entero.", num1);
            }

            if (num2 < 0)
            {
                Console.WriteLine("El número {0} no es un número entero.", num2);
            }

            /*-----------------------------------------------------------*/
            /*Crea un menú que pida al usuario una opción del 1 al 5*/
            int opcion;

            Console.Write("Introduce un número del 1 al 5: "); 
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) 
            { 
                case 1: 
                    Console.WriteLine("Has ecogido la opción: {0}", opcion); 
                    break; 
                case 2: 
                    Console.WriteLine("Has ecogido la opción: {0}", opcion); 
                    break; 
                case 3: 
                    Console.WriteLine("Has ecogido la opción: {0}", opcion); 
                    break; 
                case 4: 
                    Console.WriteLine("Has ecogido la opción: {0}", opcion); 
                    break; 
                case 5: 
                    Console.WriteLine("Has ecogido la opción: {0}", opcion); 
                    break; 
                default: 
                    Console.WriteLine("No es una opción del 1 al 5"); 
                    break; 
            }
        }
    }
}
