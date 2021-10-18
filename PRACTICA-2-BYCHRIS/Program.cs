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
                    Console.WriteLine("*                                                                                   *");
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
                        Console.WriteLine("--------------> Numeros mayor <--------------");
                        Console.WriteLine("Porfavor ingrese dos numeros");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());
                        if (num1 > num2)
                        {
                            if (num1 == num2)
                            {
                                Console.WriteLine("Los numeros ingresados son iguales");
                                Console.WriteLine("Porfavor ingrese numeros diferentes");
                                
                            }
                            else
                            {
                                Console.WriteLine("Del " + num1 + " y " + num2 + " El numero mayor es : " + num1);
                            }
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Del " + num1 + " y " + num2 + " El numero mayor es : " + num2);
                        }

                            Console.WriteLine("Presione enter para volver al menu");


                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("--------------> Numeros pares <--------------");

                        Console.WriteLine("Ingrese un numero para evaluar si es par o no");
                       
                        int N1 = int.Parse(Console.ReadLine());
                            if ((N1 %2) == 0)
                        {
                            Console.WriteLine("El numero que ingreso es par");
                        }
                            else
                        {
                            Console.WriteLine("El numero que ingreso es impar");
                        }
                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--------------> Numero mayor entre tres valores <--------------");
                        Console.WriteLine("Porfavor ingrese tres numeros");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = int.Parse(Console.ReadLine());
                        int n3 = int.Parse(Console.ReadLine());
                        if (n1 >= n2 && n1>=n3)
                        {
                            Console.WriteLine("El numero mayor ingresado es: "+n1);
                           
                        }
                        else
                        {
                            if (n2 > n3)
                            {
                                Console.WriteLine("El numero mayor ingresado es: " + n2);
                            }
                            else
                            {
                                Console.WriteLine("El numero mayor ingresado es: " + n3);
                            }
                        }
                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("--------------> Ingreso de valores hasta que se ingrese un 0<--------------");
                        Console.WriteLine("Ingrese los numeros decimales que quiera");
                        Console.WriteLine("Ingrese un 0 para parar de ingresar");

                        double Var = 1;
                        while (Var != 0)
                        {

                            Var = Convert.ToDouble(Console.ReadLine());
                           

                        }
                        Console.WriteLine("El programa termino");
                        Console.WriteLine();

                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("--------------> Suma de 5 valores <--------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int V1 = int.Parse(Console.ReadLine());
                        int V2 = int.Parse(Console.ReadLine());
                        int V3 = int.Parse(Console.ReadLine());
                        int V4 = int.Parse(Console.ReadLine());
                        int V5 = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("La suma de los valores ingresados es :");

                        int Suma;
                        Suma = V1 + V2 + V3 + V4 + V5;

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine(V1+" + "+V2+ " + "+V3+ " + "+V4+ " + "+ V5+" = "+Suma);


                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine("--------------> Suma de valores ingresados por usuario <--------------");
                        Console.WriteLine("Ingrese los numeros que quiera");
                        
                        double Dat = 1, suma=0;
                        while (Dat != 0)
                        {

                            Dat = Convert.ToDouble(Console.ReadLine());
                            suma=suma+Dat;

                        }
                       
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("La suma de los datos ingresados es : "+suma);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:
                        Console.WriteLine("--------------> Tipos de triangulos <--------------");
                        Console.WriteLine();
                        
                        double lado1, lado2, lado3;
                        string answers;
                        int Next ;
                       
                        
                        do
                        {
                            Console.WriteLine("Ingrese el primer lado del triangulo");
                            lado1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo lado del triangulo");
                            lado2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer lado del triangulo");
                            lado3 = int.Parse(Console.ReadLine());
                            if (lado1 == lado2 && lado1 == lado3)
                            {
                                Console.WriteLine("El triángulo ingresado es un equilatero");
                            } 
                            else
                            {
                                if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                                {
                                    Console.WriteLine("El triángulo ingresado es un escaleno");
                                }
                                else
                                {
                                    Console.WriteLine("El triángulo ingresado es un Isóceles");
                                }
                            }

                            do
                            {
                                Next = 0;
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine(" ¿Desea volver a calcular un tringulo? ---> Responda S 'Si' || N 'No'  ");
                                answers = Console.ReadLine();
                                if (!answers.Equals("S") && !answers.Equals("N"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Porfavor ingrese una S o N");
                                    Next = 1;
                                }

                            } while (Next == 1);
      
                        } while (answers.Equals("S"));



                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("--------------> Numeros pares <--------------");

                        int Counter = 0;

                        Console.WriteLine("Presione enter para mostrar los multiplos de 7 del 1 al 1000");
                        Console.ReadKey();
                        

                        while (Counter<1000)
                        {
                            Counter = Counter + 7;
                            Console.WriteLine(+Counter);
                        }


                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 9:
                        Console.Clear();
                        Console.WriteLine("--------------> Promedio <--------------");

                        Console.WriteLine("Ingrese los numeros que quiera");

                        double Val = 1, Sum = 0, Prom;
                        int contador = 0;
                        while (Val != 0)
                        {

                            Val = Convert.ToDouble(Console.ReadLine());
                            Sum = Sum + Val;
                            contador++;
                        }
                        Prom = Sum/contador;
                        Console.WriteLine("El promedio de los numeros ingreados  es : "+Prom);
                      

                        Console.WriteLine("Presione enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 0:
                        Console.WriteLine("Hasta la Proxima");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("La opcion ingresada no es correcta");
                        break;

                }

                
            } while (Menu != 0);




        }

    }
}
