using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_2_BYCHRIS
{
    //Programa Elaborado por: Christopher Tejena
    //  Realizado el 14/10/2021
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            int Menu;
            do
            {
                do
                {
                    Console.WriteLine("*************************************************************************************");
                    Console.WriteLine("*--------------------------->        PRÁCTICA 2        <----------------------------*");
                    Console.WriteLine("*                       Escoja una de las siguientes opciones                       *");
                    Console.WriteLine("*                                                                                   *");
                    Console.WriteLine("*                           1. Número Mayor                                         *");
                    Console.WriteLine("*                           2. Número Par                                           *");
                    Console.WriteLine("*                           3. Mayor de tres números                                *");
                    Console.WriteLine("*                           4. Decimales hasta el cero                              *");
                    Console.WriteLine("*                           5. Suma de 5 terminos                                   *");
                    Console.WriteLine("*                           6. Suma de terminos definidos por el                    *");
                    Console.WriteLine("*                              usuario hasta que ingrese un 0                       *");
                    Console.WriteLine("*                           7. Tipo de triangulos                                   *");
                    Console.WriteLine("*                           8. Multiplos del 7 del 1 al 1000                        *");
                    Console.WriteLine("*                           9. Promedio                                             *");
                    Console.WriteLine("*                          10. Volver al Menú                                       *");
                    Console.WriteLine("*                                                                                   *");
                    Console.WriteLine("*                                                                                   *");
                    Console.WriteLine("*                           0. Salir                                                *");
                    Console.WriteLine("*                                                                                   *");
                    Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
                    Console.WriteLine("*                           Elija una de las opciones anteriores                    *");
                    Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
                    Console.WriteLine("*                                                                                   *");
                    Console.WriteLine("*************************************************************************************");

                    Menu = Convert.ToInt32(Console.ReadLine());



                    if (Menu > 10 || Menu < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Vuelva a ingresar una opcion valida");
                        Console.WriteLine("Presione Enter para volver al menu");
                        Console.ReadLine();

                    }
                    Console.Clear();

                } while (Menu < 0 || Menu > 10);
                switch (Menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Numero mayor");
                        Console.WriteLine("Porfavor ingrese dos numeros");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());
                        if (num1 > num2)
                        {

                            Console.WriteLine("Del " + num1 + " y " + num2 + " El numero mayor es : " + num1);
                        }
                        else
                        {
                            Console.WriteLine("Del " + num1 + " y " + num2 + " El numero mayor es : " + num2);
                        }


                        //al finalizar preguntar si quiere volver al menu

                        break;


                    case 2:
                        Console.WriteLine("Hola");
                        break;

                    case 3:
                        Console.WriteLine("Hola");
                        break;

                    case 4:
                        Console.WriteLine("Hola");
                        break;

                    case 5:
                        Console.WriteLine("Hola");
                        break;

                    case 6:
                        Console.WriteLine("Hola");
                        break;

                    case 7:
                        Console.WriteLine("Hola");
                        break;

                    case 8:
                        Console.WriteLine("Hola");
                        break;

                    case 9:
                        Console.WriteLine("Hola");
                        break;

                    case 10:

                        Console.WriteLine("Hola");
                        return;

                    case 0:
                        Console.WriteLine("Hasta la Proxima");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("La opcion ingresada no es correcta");
                        break;

                }

                Console.Clear();
            } while (Menu != 0);




        }

    }
}
